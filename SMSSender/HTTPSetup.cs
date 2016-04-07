using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SMSSender
{
    public partial class HTTPSetup : Form
    {
        public HTTPSetup()
        {
            InitializeComponent();
        }

        private void HTTPSetup_Load(object sender, EventArgs e)
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
                    string[] str = Crypto.Decrypt(sr.ReadToEnd()).Split('>', ';');
                    Settings.parameters.Clear();
                    dgvParams.Rows.Clear();

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
                                txtURL.Text = str[i + 1];
                                Settings.URL = str[i + 1];
                                i++;
                            }
                            else if (str[i] == "protocol")
                            {
                                cmbProtocol.SelectedIndex = Convert.ToInt32(str[i + 1]);
                                Settings.protocol = Convert.ToInt32(str[i + 1]);
                                i++;
                            }
                            else
                            {
                                Settings.parameters.Add(new KeyValuePair<string, string>(str[i], str[i + 1]));
                                dgvParams.Rows.Add(str[i], str[i + 1]);
                                i++;
                            }
                        }
                    }
                    sr.Close();
                }
                else
                {
                    var file = File.Create("settings.cnfg");
                    file.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc, "EXCEPTION");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("settings.cnfg");
                string populatedString = "url>" + txtURL.Text + ";protocol>" + cmbProtocol.SelectedIndex + ";";
                Settings.parameters.Clear();

                Settings.protocol = cmbProtocol.SelectedIndex;
                Settings.URL = txtURL.Text;

                for (int i = 0; i < dgvParams.Rows.Count - 1; i++)
                {
                    Settings.parameters.Add(new KeyValuePair<string, string>(dgvParams[0, i].Value.ToString(), dgvParams[1, i].Value.ToString()));

                }

                for (int i = 0; i < Settings.parameters.Count; i++)
                {
                    populatedString = populatedString + Settings.parameters[i].Key + ">" + Settings.parameters[i].Value + ";";
                }
                string encryptedSettings = Crypto.Encrypt(populatedString);
                sw.Write(encryptedSettings);
                sw.Close();
                this.Close();
            }
            catch { }
        }
    }
}
