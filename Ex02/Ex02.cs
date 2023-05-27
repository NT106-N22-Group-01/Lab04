using System.Net;

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

        private async void downloadButton_Click(object sender, EventArgs e)
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

					using (var client = new WebClient())
					{
						var response = new StreamReader(await client.OpenReadTaskAsync(urlText.Text));
						await client.DownloadFileTaskAsync(urlText.Text, pathText.Text);
						Output.AppendText(await response.ReadToEndAsync());
					}
				}
                catch (Exception ex)
                {
                    Output.AppendText(ex.ToString());
                }
            }
        }
    }
}
