using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;

namespace Ex03
{
	public partial class Ex03 : Form
	{
		public Ex03()
		{
			InitializeComponent();
		}

		private async void Ex03_Load(object sender, EventArgs e)
		{
			await webView2.EnsureCoreWebView2Async(null);
		}

		private void Lab4_txtURL_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				Lab4_btnSearch.PerformClick();
			}
		}

		private void webView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
		{
			Invoke(new Action(() => Text = webView2.CoreWebView2.DocumentTitle?.ToString()));
		}

		private void Lab4_btnSearch_Click(object sender, EventArgs e)
		{
			string url = Lab4_txtURL.Text;
			if (string.IsNullOrWhiteSpace(url))
			{
				MessageBox.Show("Lỗi", "Vui lòng điền URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!url.StartsWith("http://") && !url.StartsWith("https://"))
			{
				url = "http://" + url;
				Lab4_txtURL.Text = url;
			}
			webView2.CoreWebView2.Navigate(url);
		}

		private async void Lab4_btnDownload_Click(object sender, EventArgs e)
		{
			if (webView2.Source == null)
			{
				MessageBox.Show("Lỗi", "Vui lòng load web trước khi tải", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			using (var dialog = new FolderBrowserDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					string downloadDirectory = dialog.SelectedPath;

					await DownloadResourcesFromWebView(downloadDirectory);
				}
			}
		}

		private async void buttonViewSource_Click(object sender, EventArgs e)
		{
			if (webView2.Source == null)
			{
				MessageBox.Show("Lỗi", "Vui lòng load web trước khi xem source", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var html = await DownloadHTML();
			Invoke(new MethodInvoker(() =>
			{
				var sourceForm = new SourceForm(html);
				sourceForm.Show();
			}));
		}

		private async void buttonDownloadHTML_Click(object sender, EventArgs e)
		{
			if (webView2.Source == null)
			{
				MessageBox.Show("Lỗi", "Vui lòng load web trước khi tải", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var html = await DownloadHTML();
			if (!string.IsNullOrEmpty(html))
			{
				using (var saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "HTML files (*.html)|*.html";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.WriteAllText(saveFileDialog.FileName, html);
					}
				}
			}
		}

		private async Task<string> DownloadHTML()
		{
			var html = await webView2.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");
			html = Regex.Unescape(html);
			html = html.Remove(0, 1);
			html = html.Remove(html.Length - 1, 1);
			return html;
		}

		private async Task DownloadResourcesFromWebView(string downloadDirectory)
		{
			string html = await DownloadHTML();

			// Sử dụng HTMLAgilityPack để phân tích HTML
			var htmlDocument = new HtmlAgilityPack.HtmlDocument();
			htmlDocument.LoadHtml(html);

			var htmlFileName = "page.html";
			File.WriteAllText(Path.Combine(downloadDirectory, htmlFileName), html);

			Directory.CreateDirectory(downloadDirectory);

			using (WebClient webClient = new WebClient())
			{
				var imageNodes = htmlDocument.DocumentNode.Descendants("img");
				foreach (var imageNode in imageNodes)
				{
					string imageUrl = imageNode.GetAttributeValue("src", "");
					imageUrl = webView2.Source.ToString() + imageUrl;

					string fileName = Path.GetFileName(imageUrl);
					string filePath = Path.Combine(downloadDirectory, fileName);

					try
					{
						// Tiến hành tải xuống hình ảnh
						await webClient.DownloadFileTaskAsync(imageUrl, filePath);
						Console.WriteLine("Downloaded image: " + fileName);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Failed to download image: " + fileName);
						Console.WriteLine("Error: " + ex.Message);
					}
				}

				var linkNodes = htmlDocument.DocumentNode.Descendants("a");

				// Lặp qua tất cả các thẻ <a> và tải xuống các liên kết
				foreach (var linkNode in linkNodes)
				{
					string linkUrl = linkNode.GetAttributeValue("href", "");
					linkUrl = webView2.Source.ToString() + linkUrl;

					string fileName = Path.GetFileName(linkUrl);
					string filePath = Path.Combine(downloadDirectory, fileName);

					try
					{
						// Tiến hành tải xuống liên kết
						await webClient.DownloadFileTaskAsync(linkUrl, filePath);
						Console.WriteLine("Downloaded file: " + fileName);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Failed to download file: " + fileName);
						Console.WriteLine("Error: " + ex.Message);
					}
				}
			}

			MessageBox.Show("Completed", "Tải xuống hoàn tất.", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

}
