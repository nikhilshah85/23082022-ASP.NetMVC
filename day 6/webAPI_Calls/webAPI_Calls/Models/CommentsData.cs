namespace webAPI_Calls.Models
{
    public class CommentsData
    {
        public int postId { get; set; }
        public int id { get; set; }

        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }


        public List<CommentsData> GetComments()
        {
            string url = "https://jsonplaceholder.typicode.com/comments";
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            List<CommentsData> data = new List<CommentsData>();
            var callService = client.GetAsync(url);
            var response = callService.Result;
            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsAsync<List<CommentsData>>();
                read.Wait();
                data = read.Result;
            }
            return data;
        }
    }
}
