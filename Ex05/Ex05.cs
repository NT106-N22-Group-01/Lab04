using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;


namespace Ex05
{
    public partial class Ex05 : Form
    {
        public Ex05()
        {
            InitializeComponent();
            Output.ReadOnly = true;
            Output.ScrollBars = ScrollBars.Both;
            urlText.ReadOnly = true;
            urlText.Text = @"https://reqres.in/api/register";
            usrText.ReadOnly = true;
            usrText.Text = @"eve.holt@reqres.in";
            pwdText.ReadOnly = true;
            pwdText.Text = @"pistol";
        }

        private async void postButton_Click(object sender, EventArgs e)
        {
            Output.Clear();
            var email = usrText.Text;
            var password = pwdText.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out.", "Note:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var client = new HttpClient();
            var values = new Dictionary<string, string>
            {
                { "email", email },
                { "password", password }
            };

            var content = new FormUrlEncodedContent(values);
            using (var response = await client.PostAsync(urlText.Text, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    dynamic json = JObject.Parse(responseContent);
                    var id = json.id;
                    var token = json.token;
                    Output.AppendText($"{id}\r\n{token}");
                   
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
