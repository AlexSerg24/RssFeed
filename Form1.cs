using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;

namespace WindowsFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[,] rssData = null;
        Settings settings = new Settings();
        Timer timer = new Timer(); //таймер, который будет вызывать обновление ленты
        DateTime date1; // даты для таймера обратного отсчета
        DateTime date2;
        Form2 SettingsForm;
        public bool DescriptionVisibility = true; 
        public bool DateVisibility = true;
        public String GetFrequency()
        {
            return settings.Frequency;
        }

        public void SetFrequency(String fr)
        {
            settings.Frequency = fr;
            timer.Stop();
            timer.Interval = int.Parse(fr) * 1000 * 60;
            timer.Start();
            date1 = new DateTime(2015, 7, 20, 18, int.Parse(fr), 0);
        }

        private String[,] getRssData(string channel)
        {
            try
            {
                WebRequest request = WebRequest.Create(channel);
                request.Proxy.Credentials = new NetworkCredential(settings.Login, settings.Password);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                WebResponse response = request.GetResponse();

                System.IO.Stream rssStream = response.GetResponseStream();
                System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

                rssDoc.Load(rssStream);

                System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

                String[,] tempRssData = new String[100, 4];

                for (int i = 0; i < rssItems.Count; i++)
                {
                    System.Xml.XmlNode rssNode;

                    rssNode = rssItems.Item(i).SelectSingleNode("title");
                    if (rssNode != null)
                    {
                        tempRssData[i, 0] = rssNode.InnerText;
                    }
                    else
                    {
                        tempRssData[i, 0] = "";
                    }

                    rssNode = rssItems.Item(i).SelectSingleNode("description");
                    if (rssNode != null)
                    {
                        tempRssData[i, 1] = rssNode.InnerText;
                    }
                    else
                    {
                        tempRssData[i, 1] = "";
                    }

                    rssNode = rssItems.Item(i).SelectSingleNode("link");
                    if (rssNode != null)
                    {
                        tempRssData[i, 2] = rssNode.InnerText;
                    }
                    else
                    {
                        tempRssData[i, 2] = "";
                    }

                    rssNode = rssItems.Item(i).SelectSingleNode("pubDate");
                    if (rssNode != null)
                    {
                        tempRssData[i, 3] = rssNode.InnerText;
                    }
                    else
                    {
                        tempRssData[i, 3] = "";
                    }
                }
                return tempRssData;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка! С данной ссылки невозможно получить ленту. \r\n" + e.Message);
                String[,] noData = new String[50, 4];
                return noData;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            RefreshFeeds();
            timer.Enabled = true;
            timer.Start();
            date1 = new DateTime(2015, 7, 20, 18, int.Parse(settings.Frequency), 0);
            WaitTimer.Enabled = true;
            WaitTimer.Start();
        }

        private void TitlesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[TitlesComboBox.SelectedIndex, 1] != null)
                DescriptionTextBox.Text = rssData[TitlesComboBox.SelectedIndex, 1];
            else          
                DescriptionTextBox.Text = "No Description text...";           
            if (rssData[TitlesComboBox.SelectedIndex, 2] != null)
                linkLabel.Text = "Go to: " + rssData[TitlesComboBox.SelectedIndex, 0];
            else
                linkLabel.Text = "No Link...";
            if (rssData[TitlesComboBox.SelectedIndex, 3] != null)
            {
                var value = DateTime.Parse(rssData[TitlesComboBox.SelectedIndex, 3], System.Globalization.CultureInfo.InvariantCulture);
                DateLabel.Text = "Date: " + value.ToString();
            }
            else
                DateLabel.Text = "No Date Info";
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rssData[TitlesComboBox.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(rssData[TitlesComboBox.SelectedIndex, 2]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("settings.xml"))
            {
                CreateSettingsXML();
            }
            LoadSettings();
            rssData = getRssData("http://www.dotnetawesome.com/feeds/posts/default?alt=rss");
            ChannelTextBox.Text = settings.Link;
            timer.Enabled = false;
            timer.Interval = int.Parse(settings.Frequency) * 1000 * 60; // Frequecny в минутах, а таймер в милисекундах
            timer.Tick += timer_Tick;
            timer.Tick += TitlesComboBox_SelectedIndexChanged;
            date1 = new DateTime(2015, 7, 20, 18, int.Parse(settings.Frequency), 0);
            date2 = new DateTime(2015, 7, 20, 18, 0, 1);
        }

        private void timer_Tick (object sender, System.EventArgs e)
        {
            RefreshFeeds();
            date1 = new DateTime(2015, 7, 20, 18, int.Parse(settings.Frequency), 0);
        }

        private void CreateSettingsXML()
        {
            XDocument xdoc = new XDocument();
            XElement setting = new XElement("settings");
            XAttribute settingLogin = new XAttribute("login", "sasha8726772@gmail.com"); 
            XElement settingPassword = new XElement("password", "Task1234");
            XElement settingfrequency = new XElement("frequency", 3);
            XElement settingLink = new XElement("link", "https://habr.com/rss/interesting/");
            setting.Add(settingLogin);
            setting.Add(settingPassword);
            setting.Add(settingfrequency);
            setting.Add(settingLink);
            xdoc.Add(setting);
            xdoc.Save("settings.xml");            
        }

        private void LoadSettings()
        {
            XDocument xdoc = XDocument.Load("settings.xml");
            var setting = xdoc.Element("settings");
            if (setting != null)
            {
                settings.Login = setting?.Attribute("login")?.Value;
                settings.Password = setting?.Element("password")?.Value;
                settings.Frequency = setting?.Element("frequency")?.Value;
                settings.Link = setting?.Element("link")?.Value;
            }
        }

        private void RefreshFeeds()
        {
            TitlesComboBox.Items.Clear();
            rssData = getRssData(ChannelTextBox.Text);
            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    TitlesComboBox.Items.Add(rssData[i, 0]);
                }
                if (TitlesComboBox.Items.Count != 0)
                {
                    TitlesComboBox.SelectedIndex = 0;
                }
            }
        }

        private void ChannelTextBox_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            WaitTimer.Stop();
            WaitTimer.Enabled = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm = new Form2();
            SettingsForm.MainForm = this;
            SettingsForm.Show();
        }

        public void ChangeDiscriptionVisibility()
        {
            DescriptionTextBox.Visible = !DescriptionTextBox.Visible;
            DescriptionVisibility = !DescriptionVisibility;
        }

        public void ChangeDataVisibility()
        {
            DateLabel.Visible = !DateLabel.Visible;
            DateVisibility = !DateVisibility;
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = date1.Subtract(date2).ToString().Substring(3);
            date1 = date1.AddSeconds(-1);
        }
    }
}
