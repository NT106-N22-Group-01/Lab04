using Newtonsoft.Json;

namespace Ex04
{
	public partial class Ex04 : Form
	{
		string _apiUrl = "https://reqres.in";
		Label[] labels;
		GroupBox[] groupBoxes;
		PictureBox[] pictureBoxes;
		ApiResponse _api;


		public Ex04()
		{
			InitializeComponent();
			labels = new[] { labelID1, labelID2, labelID3, labelID4, labelID5, labelID6 };
			groupBoxes = new[] { groupBoxID1, groupBoxID2, groupBoxID3, groupBoxID4, groupBoxID5, groupBoxID6 };
			pictureBoxes = new[] { pictureBoxID1, pictureBoxID2, pictureBoxID3, pictureBoxID4, pictureBoxID5, pictureBoxID6 };
		}

		private async Task<ApiResponse> GetApiResponse(int pageNumber)
		{
			using (var httpClient = new HttpClient())
			{
				var result = await httpClient.GetAsync(_apiUrl + $"/api/users?page={pageNumber}");
				var response = await result.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<ApiResponse>(response);
			}
		}

		private async void Ex04_Load(object sender, EventArgs e)
		{
			_api = await GetApiResponse(1);
			LoadInfomation(_api);
		}

		private async void LoadInfomation(ApiResponse api)
		{
			labelNumPage.Text = api.page.ToString();
			labelNumUserPerPage.Text = api.per_page.ToString();
			labelNumTotalPage.Text = api.total_pages.ToString();
			labelNumTotalUser.Text = api.total.ToString();
			for (int i = 0; i < api.per_page; i++)
			{
				groupBoxes[i].Text = $"{api.data[i].first_name} {api.data[i].last_name}";
				labels[i].Text = api.data[i].email;
				pictureBoxes[i].ImageLocation = api.data[i].avatar;
			}
		}

		private async void buttonNext_Click(object sender, EventArgs e)
		{
			if (_api.page == _api.total_pages)
				return;
			_api = await GetApiResponse(_api.page + 1);
			LoadInfomation(_api);
		}

		private async void buttonPrev_Click(object sender, EventArgs e)
		{
			if (_api.page == 1)
				return;
			_api = await GetApiResponse(_api.page - 1);
			LoadInfomation(_api);
		}
	}
}