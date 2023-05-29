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
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Ex06
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private List<News> newsList = new List<News>();

        private string extractHTML(string url)
        {
            string script = "";

            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    script = reader.ReadToEnd();
                }
            }

            return script;
        }

        private News createNews(string title, string descript, string image, string url)
        {
            News newspiece = new News()
            {
                Title = title,
                Description = descript,
                Thumbnail = image,
                URL = url
            };

            return newspiece;
        }

        private void addNews(News news)
        {
            if (newsList.Contains(news) == false)
                newsList.Add(news);

            progBar.Value++;
        }

        private void extractNodes(string script, string title, string descript, string image, string url)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(script);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//article");
            progBar.Maximum = nodes.Count();

            foreach (HtmlNode n in nodes)
            {
                HtmlNode nodeTitle = n.SelectSingleNode(".//h3[@class='title-news']");
                HtmlNode nodeURL = n.SelectSingleNode(".//a");
                HtmlNode nodeDescript = n.SelectSingleNode(".//p[@class='description']");
                HtmlNode nodeImage = n.SelectSingleNode(".//img");

                if (nodeTitle != null)
                {
                    nodeTitle = n.SelectSingleNode(".//a");

                    if (nodeTitle != null)
                        title = nodeTitle.Attributes["title"].Value;
                }    

                if (nodeDescript != null)
                    descript = nodeDescript.InnerText;
                
                
                if (nodeImage != null)
                {
                    image = nodeImage.Attributes["src"].Value;

                    if (image.Contains("https://") == false)
                      image = nodeImage.Attributes["data-src"].Value;
                }  
                
                if (nodeURL != null)
                    url = nodeURL.Attributes["href"].Value;

                News newspiece = createNews(title, descript, image, url);
                addNews(newspiece);
            }
        }

        private void displayNews()
        {
            foreach (News news in newsList)
                flpNews.Controls.Add(news);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                string title = "", descript = "", image = "", url = "";
                progBar.Value = progBar.Minimum = 0;

                string script = extractHTML(tbURL.Text.Trim());
                extractNodes(script, title, descript, image, url);
                displayNews();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
