
namespace WindowsFormTest
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.UpFrequencyButton = new System.Windows.Forms.Button();
            this.DownFrequencyButton = new System.Windows.Forms.Button();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescriptionCheckBox
            // 
            this.DescriptionCheckBox.AutoSize = true;
            this.DescriptionCheckBox.Checked = true;
            this.DescriptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DescriptionCheckBox.Location = new System.Drawing.Point(93, 45);
            this.DescriptionCheckBox.Name = "DescriptionCheckBox";
            this.DescriptionCheckBox.Size = new System.Drawing.Size(79, 17);
            this.DescriptionCheckBox.TabIndex = 0;
            this.DescriptionCheckBox.Text = "Description";
            this.DescriptionCheckBox.UseVisualStyleBackColor = true;
            this.DescriptionCheckBox.CheckedChanged += new System.EventHandler(this.DescriptionCheckBox_CheckedChanged);
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Checked = true;
            this.DateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DateCheckBox.Location = new System.Drawing.Point(93, 68);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.DateCheckBox.TabIndex = 1;
            this.DateCheckBox.Text = "Date";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show/Hide";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frequency (minutes)";
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Location = new System.Drawing.Point(129, 140);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(13, 13);
            this.FrequencyLabel.TabIndex = 4;
            this.FrequencyLabel.Text = "0";
            // 
            // UpFrequencyButton
            // 
            this.UpFrequencyButton.AutoSize = true;
            this.UpFrequencyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpFrequencyButton.Location = new System.Drawing.Point(93, 135);
            this.UpFrequencyButton.Name = "UpFrequencyButton";
            this.UpFrequencyButton.Size = new System.Drawing.Size(23, 23);
            this.UpFrequencyButton.TabIndex = 5;
            this.UpFrequencyButton.Text = "+";
            this.UpFrequencyButton.UseVisualStyleBackColor = true;
            this.UpFrequencyButton.Click += new System.EventHandler(this.UpFrequencyButton_Click);
            // 
            // DownFrequencyButton
            // 
            this.DownFrequencyButton.AutoSize = true;
            this.DownFrequencyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DownFrequencyButton.Location = new System.Drawing.Point(159, 135);
            this.DownFrequencyButton.Name = "DownFrequencyButton";
            this.DownFrequencyButton.Size = new System.Drawing.Size(20, 23);
            this.DownFrequencyButton.TabIndex = 6;
            this.DownFrequencyButton.Text = "-";
            this.DownFrequencyButton.UseVisualStyleBackColor = true;
            this.DownFrequencyButton.Click += new System.EventHandler(this.DownFrequencyButton_Click);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangeColorButton.Location = new System.Drawing.Point(97, 191);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(75, 55);
            this.ChangeColorButton.TabIndex = 7;
            this.ChangeColorButton.Text = "Change form color";
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(281, 278);
            this.Controls.Add(this.ChangeColorButton);
            this.Controls.Add(this.DownFrequencyButton);
            this.Controls.Add(this.UpFrequencyButton);
            this.Controls.Add(this.FrequencyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateCheckBox);
            this.Controls.Add(this.DescriptionCheckBox);
            this.Name = "Form2";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DescriptionCheckBox;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.Button UpFrequencyButton;
        private System.Windows.Forms.Button DownFrequencyButton;
        private System.Windows.Forms.Button ChangeColorButton;
    }
}