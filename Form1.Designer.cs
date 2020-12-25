
using System.Windows.Forms;

namespace GetDbmData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UtilityPanel = new System.Windows.Forms.Panel();
            this.CloseTabBtn = new System.Windows.Forms.Button();
            this.NewTabBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLapseTxtBox = new System.Windows.Forms.TextBox();
            this.Blinker = new System.Windows.Forms.RadioButton();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.NewUrlTxtBox = new System.Windows.Forms.TextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.UtilityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Location = new System.Drawing.Point(12, 109);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1078, 531);
            this.Tabs.TabIndex = 0;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1070, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UtilityPanel
            // 
            this.UtilityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UtilityPanel.BackColor = System.Drawing.Color.Black;
            this.UtilityPanel.Controls.Add(this.CloseTabBtn);
            this.UtilityPanel.Controls.Add(this.NewTabBtn);
            this.UtilityPanel.Controls.Add(this.label2);
            this.UtilityPanel.Controls.Add(this.TimeLapseTxtBox);
            this.UtilityPanel.Controls.Add(this.Blinker);
            this.UtilityPanel.Controls.Add(this.StopButton);
            this.UtilityPanel.Controls.Add(this.StartBtn);
            this.UtilityPanel.Controls.Add(this.NewUrlTxtBox);
            this.UtilityPanel.Controls.Add(this.GoBtn);
            this.UtilityPanel.Location = new System.Drawing.Point(12, 12);
            this.UtilityPanel.Name = "UtilityPanel";
            this.UtilityPanel.Size = new System.Drawing.Size(1078, 90);
            this.UtilityPanel.TabIndex = 0;
            // 
            // CloseTabBtn
            // 
            this.CloseTabBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseTabBtn.Location = new System.Drawing.Point(99, 10);
            this.CloseTabBtn.Name = "CloseTabBtn";
            this.CloseTabBtn.Size = new System.Drawing.Size(135, 29);
            this.CloseTabBtn.TabIndex = 4;
            this.CloseTabBtn.Text = "Close Current Tab";
            this.CloseTabBtn.UseVisualStyleBackColor = true;
            this.CloseTabBtn.Click += new System.EventHandler(this.CloseTabBtn_Click);
            // 
            // NewTabBtn
            // 
            this.NewTabBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewTabBtn.Location = new System.Drawing.Point(14, 10);
            this.NewTabBtn.Name = "NewTabBtn";
            this.NewTabBtn.Size = new System.Drawing.Size(79, 29);
            this.NewTabBtn.TabIndex = 1;
            this.NewTabBtn.Text = "New Tab";
            this.NewTabBtn.UseVisualStyleBackColor = true;
            this.NewTabBtn.Click += new System.EventHandler(this.NewTabBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(782, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time lapse (ms) - min: 100";
            // 
            // TimeLapseTxtBox
            // 
            this.TimeLapseTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLapseTxtBox.Location = new System.Drawing.Point(976, 54);
            this.TimeLapseTxtBox.Name = "TimeLapseTxtBox";
            this.TimeLapseTxtBox.Size = new System.Drawing.Size(94, 27);
            this.TimeLapseTxtBox.TabIndex = 3;
            this.TimeLapseTxtBox.TextChanged += new System.EventHandler(this.TimeLapseTxtBox_TextChanged);
            // 
            // Blinker
            // 
            this.Blinker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Blinker.AutoSize = true;
            this.Blinker.Location = new System.Drawing.Point(853, 16);
            this.Blinker.Name = "Blinker";
            this.Blinker.Size = new System.Drawing.Size(17, 16);
            this.Blinker.TabIndex = 1;
            this.Blinker.TabStop = true;
            this.Blinker.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Location = new System.Drawing.Point(876, 10);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 29);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Location = new System.Drawing.Point(976, 10);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(94, 29);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // NewUrlTxtBox
            // 
            this.NewUrlTxtBox.Location = new System.Drawing.Point(18, 53);
            this.NewUrlTxtBox.Name = "NewUrlTxtBox";
            this.NewUrlTxtBox.PlaceholderText = "Insert New Url";
            this.NewUrlTxtBox.Size = new System.Drawing.Size(321, 27);
            this.NewUrlTxtBox.TabIndex = 2;
            this.NewUrlTxtBox.TextChanged += new System.EventHandler(this.NewUrlTxtBox_TextChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(345, 51);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(48, 29);
            this.GoBtn.TabIndex = 1;
            this.GoBtn.Text = "GO";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 652);
            this.Controls.Add(this.UtilityPanel);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Dbm Web Scrapper 3000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Tabs.ResumeLayout(false);
            this.UtilityPanel.ResumeLayout(false);
            this.UtilityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel UtilityPanel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox NewUrlTxtBox;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.RadioButton Blinker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeLapseTxtBox;
        private Button NewTabBtn;
        private Button CloseTabBtn;
    }
}

