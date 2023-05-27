using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB4_BAI3
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void Lab4_txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Lab4_btnSearch.PerformClick();
        }
        private void Lab4_btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Lab4_txtURL.Text);
        }

        private async void Lab4_btnDownload_Click(object sender, EventArgs e)
        {
            if (getSource(Lab4_txtURL.Text) == "URL không tồn tại!") { }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "HTML|*.html", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(getSource(Lab4_txtURL.Text));
                            MessageBox.Show("Tải source thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } 
            }
        }

        
    }
    
}
