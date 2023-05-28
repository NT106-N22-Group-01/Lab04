using System.Net;
using HtmlAgilityPack;

namespace Ex01
{
	public partial class Ex01 : Form
	{
		public Ex01()
		{
			InitializeComponent();
		}

		private string getSource(string URL)
		{
			try
			{
				HtmlWeb web = new HtmlWeb();
				HtmlAgilityPack.HtmlDocument content = new HtmlAgilityPack.HtmlDocument();
				content = web.Load(URL);
				string s = content.Text;
				return s;
			}
			catch
			{
				return "URL không tồn tại!";
			}
		}
		private string GetHTML(string szURL)
		{
			try
			{
				// Create a request for the URL.
				WebRequest request = WebRequest.Create(szURL);
				// Get the response.
				WebResponse response = request.GetResponse();
				// Get the stream containing content returned by the server.
				Stream dataStream = response.GetResponseStream();
				// Open the stream using a StreamReader for easy access.
				StreamReader reader = new StreamReader(dataStream);
				// Read the content.
				string responseFromServer = reader.ReadToEnd();
				// Close the response.
				response.Close();
				return responseFromServer;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return "nothing";
			}

		}
		private void btnGet_Click(object sender, EventArgs e)
		{
			if (getSource(txtURL.Text) == "URL không tồn tại!")
			{
				MessageBox.Show("URL không tồn tại!");
			}
			else
				rtxResponse.Text = GetHTML(txtURL.Text);
		}
		private void txtURL_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnGet.PerformClick();
			}
		}
	}
}
