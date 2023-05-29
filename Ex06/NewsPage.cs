using System.Net;

namespace Ex06
{
    public partial class NewsPage : Form
    {
        public NewsPage()
        {
            InitializeComponent();
            newsBrowser.ScriptErrorsSuppressed = true;
        }

        public static string url;

        private string getNews(string url)
        {
            string script = "";

            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    script = reader.ReadToEnd();
                }
            }

            return script;
        }

        private void News_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void NewsPage_Load(object sender, EventArgs e)
        {
            string HTMLscript = getNews(url);
            newsBrowser.DocumentText = HTMLscript;
        }
    }
}
