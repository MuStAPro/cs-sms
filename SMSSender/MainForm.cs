using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Security.Cryptography;

namespace SMSSender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static int msg_size = 160;
        private void httpSetup_Click(object sender, EventArgs e)
        {
            HTTPSetup setup = new HTTPSetup();
            setup.Show();
        }

        private void CountRemaining()
        {
            try
            {
                int cnt = message.Text.Count();
                int remaining = msg_size - cnt;
                stLbl.Text = string.Format("{0} Characters Remaining.", remaining);
                if (remaining < 0)
                {
                    sendBtn.Enabled = false;
                }
                else
                {
                    sendBtn.Enabled = true;
                }
            }
            catch { }
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            CountRemaining();
            
        }

        private void abtLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An HTTP API SMS sender, programmed to work with nearly every HTTP GET API out there :).\nCoded by: Mustafa Al-Ameen (mustapro).\nFor license please visit: https://github.com/MuStAPro/cs-sms/blob/master/LICENSE", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void isUnicode_CheckedChanged(object sender, EventArgs e)
        {
            if (isUnicode.Checked)
            {
                msg_size = 70;
                CountRemaining();
                message.MaxLength = 70;
            }
            else
            {
                msg_size = 160;
                CountRemaining();
                message.MaxLength = 160;
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string pt = "";

                if (Settings.protocol == 0)
                {
                    pt = "http://";
                }
                else if (Settings.protocol == 1)
                {
                    pt = "https://";
                }

                string url = Settings.URL;

                string rURL = pt + url + "?";

                for (int i = 0; i < Settings.parameters.Count; i++)
                {
                    if (Settings.parameters[i].Value == ("{to}"))
                    {
                        rURL = rURL + Settings.parameters[i].Key + "=" + to.Text;
                    }
                    else if (Settings.parameters[i].Value == ("{message}"))
                    {
                        rURL = rURL + Settings.parameters[i].Key + "=" + message.Text;
                    }
                    else
                    {
                        rURL = rURL + Settings.parameters[i].Key + "=" + Settings.parameters[i].Value;
                    }
                    rURL = rURL + "&";
                }

                rURL = rURL.Remove(rURL.Length - 1);

                WebRequest request = WebRequest.Create(rURL);
                if (msg_size == 70)
                {
                    request.ContentType = "application/html; charset=UTF-8";
                }
                Stream stream = request.GetResponse().GetResponseStream();
                if (!(stream == null))
                {
                    StreamReader sr = new StreamReader(stream);
                    MessageBox.Show(sr.ReadToEnd());
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                if (File.Exists("settings.cnfg"))
                {
                    StreamReader sr = new StreamReader("settings.cnfg");
                    string[] str = sr.ReadToEnd().Split(':', ';');
                    Settings.parameters.Clear();

                    if (str.Count() == 0)
                    {
                        //do nothing.
                    }
                    else
                    {
                        for (int i = 0; i < str.Count() - 1; i++)
                        {
                            if (str[i] == "url")
                            {
                                Settings.URL = str[i + 1];
                                i++;
                            }
                            else if (str[i] == "protocol")
                            {
                                Settings.protocol = Convert.ToInt32(str[i + 1]);
                                i++;
                            }
                            else
                            {
                                Settings.parameters.Add(new KeyValuePair<string, string>(str[i], str[i + 1]));
                                i++;
                            }
                        }
                    }
                    sr.Close();
                }
                else
                {
                    File.Create("settings.cnfg");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc, "EXCEPTION");
            }
        }
    }
}
