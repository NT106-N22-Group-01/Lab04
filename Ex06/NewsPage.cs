using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
