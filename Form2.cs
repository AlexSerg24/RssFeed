using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool init = true;

        public Form1 MainForm;

        private void DescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!init)
                MainForm.ChangeDiscriptionVisibility();
        }

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!init)
                MainForm.ChangeDataVisibility();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (MainForm.DescriptionVisibility == false)
                DescriptionCheckBox.Checked = false;
            if (MainForm.DateVisibility == false)
                DateCheckBox.Checked = false;
            init = false;
            FrequencyLabel.Text = MainForm.GetFrequency();
        }

        private void DownFrequencyButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(FrequencyLabel.Text) != 1)
            {
                string fr = (int.Parse(FrequencyLabel.Text) - 1).ToString();
                FrequencyLabel.Text = fr;
                MainForm.SetFrequency(fr);
            }
        }

        private void UpFrequencyButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(FrequencyLabel.Text) != 59)
            {
                string fr = (int.Parse(FrequencyLabel.Text) + 1).ToString();
                FrequencyLabel.Text = fr;
                MainForm.SetFrequency(fr);
            }
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = false;
            dialog.ShowHelp = true;
            dialog.Color = MainForm.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
                MainForm.BackColor = dialog.Color;
        }
    }
}
