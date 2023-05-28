namespace Ex03
{
	public partial class SourceForm : Form
	{
		public SourceForm(string html)
		{
			InitializeComponent();
			richTextBoxSource.Text = html;
		}
	}
}
