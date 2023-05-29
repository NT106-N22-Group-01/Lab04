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
    public partial class News : UserControl
    {
        public News()
        {
            InitializeComponent();
        }

        private string retrievedTitle;
        private string retrievedDescription;
        private string retrievedThumbnail;
        private string retrievedURL;

        public string Title
        {
            get { return this.retrievedTitle; }
            set { this.retrievedTitle = value; lbTitle.Text = value; }
        }

        public string Description
        {
            get { return this.retrievedDescription; }
            set { this.retrievedDescription = value; lbDescription.Text = value; }
        }

        public string Thumbnail
        {
            get { return this.retrievedThumbnail; }
            set
            {
                this.retrievedThumbnail = value;
                WebRequest request = WebRequest.Create(value);

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        pbThumbnail.Image = Bitmap.FromStream(stream);
                    }
                }
            }
        }

        public string URL
        {
            get { return this.retrievedURL; }
            set { this.retrievedURL = value; }
        }

        private void lbDescription_Click(object sender, EventArgs e)
        {

        }

        private void News_DoubleClick(object sender, EventArgs e)
        {

        }

        private void News_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NewsPage page = new NewsPage();
            NewsPage.url = this.retrievedURL;
            page.Show();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbDescription_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NewsPage page = new NewsPage();
            NewsPage.url = this.retrievedURL;
            page.Show();
        }

        private void lbTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NewsPage page = new NewsPage();
            NewsPage.url = this.retrievedURL;
            page.Show();
        }

        private void pbThumbnail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NewsPage page = new NewsPage();
            NewsPage.url = this.retrievedURL;
            page.Show();
        }
    }
}
