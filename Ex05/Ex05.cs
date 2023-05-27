using System.Text.Json.Nodes;

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
                    var json = JsonObject.Parse(responseContent);
                    var id = json?["id"].GetValue<int>();
					var token = json?["token"].GetValue<string>();
					Output.AppendText($"id: {id}\r\ntoken: {token}");          
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
