namespace Ex04
{
	public class ApiResponse
	{
		public int page { get; set; }
		public int per_page { get; set; }
		public int total { get; set; }
		public int total_pages { get; set; }
		public User[] data { get; set; }
		public Support support { get; set; }
	}

	public class User
	{
		public int id { get; set; }
		public string email { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string avatar { get; set; }
	}

	public class Support
	{
		public string Url { get; set; }
		public string Text { get; set; }
	}
}
