
namespace WindowsFormTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadButton = new System.Windows.Forms.Button();
            this.TitlesComboBox = new System.Windows.Forms.ComboBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.ChannelTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.WaitTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadButton.Location = new System.Drawing.Point(357, 33);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // TitlesComboBox
            // 
            this.TitlesComboBox.FormattingEnabled = true;
            this.TitlesComboBox.Location = new System.Drawing.Point(12, 62);
            this.TitlesComboBox.Name = "TitlesComboBox";
            this.TitlesComboBox.Size = new System.Drawing.Size(333, 21);
            this.TitlesComboBox.TabIndex = 1;
            this.TitlesComboBox.SelectedIndexChanged += new System.EventHandler(this.TitlesComboBox_SelectedIndexChanged);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoEllipsis = true;
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(12, 314);
            this.linkLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.linkLabel.MinimumSize = new System.Drawing.Size(400, 35);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(400, 35);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Go to";
            this.linkLabel.UseCompatibleTextRendering = true;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // ChannelTextBox
            // 
            this.ChannelTextBox.Location = new System.Drawing.Point(12, 33);
            this.ChannelTextBox.Name = "ChannelTextBox";
            this.ChannelTextBox.Size = new System.Drawing.Size(333, 20);
            this.ChannelTextBox.TabIndex = 3;
            this.ChannelTextBox.TextChanged += new System.EventHandler(this.ChannelTextBox_TextChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 89);
            this.DescriptionTextBox.MaximumSize = new System.Drawing.Size(333, 200);
            this.DescriptionTextBox.MinimumSize = new System.Drawing.Size(333, 200);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(333, 200);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Write link here:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 292);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Date";
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SettingsButton.Location = new System.Drawing.Point(357, 147);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(372, 92);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(13, 13);
            this.TimerLabel.TabIndex = 8;
            this.TimerLabel.Text = "0";
            // 
            // WaitTimer
            // 
            this.WaitTimer.Interval = 1000;
            this.WaitTimer.Tick += new System.EventHandler(this.WaitTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time to refresh:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.ChannelTextBox);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.TitlesComboBox);
            this.Controls.Add(this.LoadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RssFeed";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ComboBox TitlesComboBox;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.TextBox ChannelTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer WaitTimer;
        private System.Windows.Forms.Label label2;
    }
}

