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

namespace Ex02
{
    public partial class Ex02 : Form
    {
        public Ex02()
        {
            InitializeComponent();
            Output.ReadOnly = true;
            Output.ScrollBars = ScrollBars.Both;
            pathText.Text = @".\index.html";
            pathText.ReadOnly = true;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pathText.Text) || string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("Please fill out.", "Note:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                try
                {
                    if (urlText.Text.StartsWith("https:"))
                    {
                        urlText.Text = urlText.Text.Replace("https:", "http:");
                    }

                    if (!urlText.Text.StartsWith("http://"))
                    {
                        urlText.Text = urlText.Text.Insert(0, "http://");
                    }

                    var client = new WebClient();
                    var response = new StreamReader(client.OpenRead(urlText.Text));
                    client.DownloadFile(urlText.Text, pathText.Text);
                    Output.AppendText(response.ReadToEnd());
                }
                catch (Exception ex)
                {
                    Output.AppendText(ex.ToString());
                }
            }
        }
    }
}
