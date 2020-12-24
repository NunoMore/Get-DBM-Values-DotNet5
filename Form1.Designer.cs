
namespace GetDbmData2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLapseTxtBox = new System.Windows.Forms.TextBox();
            this.Blinker = new System.Windows.Forms.RadioButton();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.NewUrlTxtBox = new System.Windows.Forms.TextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.UtilityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1083, 668);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UtilityPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UtilityPanel
            // 
            this.UtilityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UtilityPanel.BackColor = System.Drawing.Color.Black;
            this.UtilityPanel.Controls.Add(this.label1);
            this.UtilityPanel.Controls.Add(this.label2);
            this.UtilityPanel.Controls.Add(this.TimeLapseTxtBox);
            this.UtilityPanel.Controls.Add(this.Blinker);
            this.UtilityPanel.Controls.Add(this.StopButton);
            this.UtilityPanel.Controls.Add(this.StartBtn);
            this.UtilityPanel.Controls.Add(this.NewUrlTxtBox);
            this.UtilityPanel.Controls.Add(this.GoBtn);
            this.UtilityPanel.Location = new System.Drawing.Point(620, 3);
            this.UtilityPanel.Name = "UtilityPanel";
            this.UtilityPanel.Size = new System.Drawing.Size(452, 141);
            this.UtilityPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "NEW URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(134, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time lapse (ms) - min: 100";
            // 
            // TimeLapseTxtBox
            // 
            this.TimeLapseTxtBox.Location = new System.Drawing.Point(328, 58);
            this.TimeLapseTxtBox.Name = "TimeLapseTxtBox";
            this.TimeLapseTxtBox.Size = new System.Drawing.Size(94, 27);
            this.TimeLapseTxtBox.TabIndex = 3;
            // 
            // Blinker
            // 
            this.Blinker.AutoSize = true;
            this.Blinker.Location = new System.Drawing.Point(428, 16);
            this.Blinker.Name = "Blinker";
            this.Blinker.Size = new System.Drawing.Size(17, 16);
            this.Blinker.TabIndex = 1;
            this.Blinker.TabStop = true;
            this.Blinker.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(228, 10);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 29);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(328, 10);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(94, 29);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // NewUrlTxtBox
            // 
            this.NewUrlTxtBox.Location = new System.Drawing.Point(16, 103);
            this.NewUrlTxtBox.Name = "NewUrlTxtBox";
            this.NewUrlTxtBox.Size = new System.Drawing.Size(352, 27);
            this.NewUrlTxtBox.TabIndex = 2;
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(374, 103);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(48, 29);
            this.GoBtn.TabIndex = 1;
            this.GoBtn.Text = "GO";
            this.GoBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 692);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
    }
}

