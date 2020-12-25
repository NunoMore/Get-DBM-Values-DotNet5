using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetDbmData2
{
    public partial class Form1 : Form
    {
        public List<ChromiumWebBrowser> chromeBrowserList = new List<ChromiumWebBrowser>();
        private bool IsStarted = false;
        private int logFrequency = 1 * 1000; // 1s by default
        private int versionNumber = 0;
        private const int maxLines = 1000 * 1000;

        private Uri uri = new Uri("http://websdr.ewi.utwente.nl:8901/"); // utwente university url by default
        private Uri uriTemp;

        private const string firstLineHeader = "DateStamp;TimeStamp;Frequency;dbmValue;dbmPeak";
        private const string dateFormat = "dd-MM-yyy";
        private const string csvSeparator = ";";
        private string defaultFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "csv_files", DateTime.Today.ToString(dateFormat));

        public Form1()
        {
            InitializeComponent();
            InitializeCefSettings();
        }

        private void InitializeCefSettings()
        {
            CefSettings settings = new CefSettings(); // Change settings as needed
            Cef.EnableHighDPISupport();
            Cef.Initialize(settings);
            InitializeChromium();

            // set time lapse log frequency value to display
            TimeLapseTxtBox.Text = logFrequency.ToString();
        }

        private void InitializeChromium()
        {
            // Create a browser component
            var chromeBrowser = new ChromiumWebBrowser(uri.ToString());
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowserList.Add(chromeBrowser);

            // Add it to the selected tab
            Tabs.SelectedTab.Controls.Add(chromeBrowser);
            SetTabText();
            try
            {
                // create folder if not exists
                Directory.CreateDirectory(defaultFolderPath);
            }
            catch (Exception e)
            {
                ErrorHandle($"[Error creating folder] - {e.Message}");
            }

            // set url value to display
            SetNewUrlText();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsStarted = false;
            Cef.Shutdown();
            chromeBrowserList.ForEach(b => b.Dispose());
        }

        // START BUTTON
        private void StartBtn_Click(object sender, EventArgs e)
        {
            IsStarted = true;

            // disable clicks until stopped
            StartBtn.Click -= StartBtn_Click;

            // hide button until stopped
            StartBtn.Hide();

            // do asynchronously
            WriteData();
        }

        // STOP BUTTON
        private void StopButton_Click(object sender, EventArgs e)
        {
            IsStarted = false;

            // enable click
            StartBtn.Click += StartBtn_Click;

            // show button
            StartBtn.Show();
        }

        private async void WriteData()
        {
            string EvaluateJavaScriptResult;
            while (IsStarted)
            {
                await Task.Delay(logFrequency);
                Blinker.Checked = !Blinker.Checked;

                chromeBrowserList.ForEach(async chromeBrowser =>
                {
                    var frame = chromeBrowser.GetMainFrame();
                    var task_dbmValue = frame.EvaluateScriptAsync("document.getElementById('numericalsmeter').innerHTML;", null);
                    string dbmValue = "no value";
                    var task_dbmPeak = frame.EvaluateScriptAsync("document.getElementById('numericalsmeterpeak').innerHTML;", null);
                    string dbmPeak = "no value";
                    var task_frequency = frame.EvaluateScriptAsync("document.getElementsByName('frequency')[0].value;", null);
                    var frequency = "no value";

                    // get dbm value
                    await task_dbmValue.ContinueWith(t =>
                    {
                        if (!t.IsFaulted)
                        {
                            var response = t.Result;
                            EvaluateJavaScriptResult = response.Success ? (response.Result != null ? response.Result.ToString() : "null") : response.Message;
                            var splittedResult = EvaluateJavaScriptResult.Split(';');
                            dbmValue = splittedResult.Length > 1 ? splittedResult[splittedResult.Length - 1] : EvaluateJavaScriptResult;
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());

                    // get dbm peak
                    await task_dbmPeak.ContinueWith(t =>
                    {
                        if (!t.IsFaulted)
                        {
                            var response = t.Result;
                            EvaluateJavaScriptResult = response.Success ? (response.Result != null ? response.Result.ToString() : "null") : response.Message;
                            var splittedResult = EvaluateJavaScriptResult.Split(';');
                            dbmPeak = splittedResult.Length > 1 ? splittedResult[splittedResult.Length - 1] : EvaluateJavaScriptResult;
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());

                    // get Frequency
                    await task_frequency.ContinueWith(t =>
                    {
                        if (!t.IsFaulted)
                        {
                            var response = t.Result;
                            EvaluateJavaScriptResult = response.Success ? (response.Result != null ? response.Result.ToString() : "null") : response.Message;
                            frequency = EvaluateJavaScriptResult;
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());

                    // write lines after all tasks are done
                    await Task.WhenAll(task_dbmValue, task_dbmPeak, task_frequency).ContinueWith(t =>
                    {
                        try
                        {
                            var filePath = GetFilePath();
                            if (!Directory.Exists(defaultFolderPath)) Directory.CreateDirectory(defaultFolderPath);
                            if (!File.Exists(filePath)) File.Create(filePath).Close();

                            var lineCount = File.ReadAllLines(filePath).Length;

                            // Increase version number of the file in question.
                            while (lineCount > maxLines)
                            {
                                versionNumber++;
                                if (!File.Exists(filePath)) File.Create(filePath);
                                lineCount = File.ReadAllLines(filePath).Length;
                            }

                            using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Append)))
                            {
                                if (lineCount == 0)
                                {
                                    writer.WriteLine(firstLineHeader);
                                }
                                var splitDateTime = DateTime.Now.ToString(dateFormat + " HH:mm:ss.fff").Split(' ');
                                writer.WriteLine($"\"{splitDateTime[0]}\"{csvSeparator}\"{splitDateTime[1]}\"{csvSeparator}{frequency}{csvSeparator}{dbmValue}{csvSeparator}{dbmPeak}");
                            }

                            // reset version number to 0
                            versionNumber = 0;
                        }
                        catch (Exception e)
                        {
                            ErrorHandle($"[Error writing to file] - {e.Message}");
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                });
            }
            Blinker.Checked = false;
        }

        // change log frequency
        private void TimeLapseTxtBox_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (!int.TryParse(tb.Text, out logFrequency))
            {
                ErrorHandle("Time lapse must be a number");
            }

            if (logFrequency < 100)
            {
                logFrequency = 100;
            }
        }

        // change url
        private void NewUrlTxtBox_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (!Uri.TryCreate(tb.Text, UriKind.RelativeOrAbsolute, out uriTemp)) // getvalue from text input
            {
                ErrorHandle("Url format not recognized");
            }
        }

        // load url
        private void GoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uri = uriTemp;
                SetTabText();
                chromeBrowserList[Tabs.SelectedIndex].Load(uri.ToString());
            }
            catch (Exception exception)
            {
                ErrorHandle($"[Error Loading Url] - {exception.Message}");
            }
        }

        private string GetFilePath() => Path.Combine(defaultFolderPath, $"{uri.Host}_{DateTime.Today.ToString(dateFormat)}_{versionNumber}.csv");

        private void ErrorHandle(string message)
        {
            MessageBox.Show(message);
            IsStarted = false;

            // enable click
            StartBtn.Click += StartBtn_Click;
            GoBtn.Click += GoBtn_Click;

            // show button
            StartBtn.Show();
            GoBtn.Show();
        }

        private void CloseTabBtn_Click(object sender, EventArgs e) => Tabs.TabPages.Remove(Tabs.SelectedTab);

        private void NewTabBtn_Click(object sender, EventArgs e)
        {
            var newTab = new TabPage();
            Tabs.TabPages.Add(newTab);
            Tabs.SelectedTab = newTab;
            InitializeChromium();
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chromeBrowserList.Count > Tabs.SelectedIndex)
            {
                SetNewUrlText();
            }
        }

        private void SetTabText() => Tabs.SelectedTab.Text = uri.Host;

        private void SetNewUrlText() => NewUrlTxtBox.Text = chromeBrowserList[Tabs.SelectedIndex].Address;
    }
}
