namespace webAPI_Calls.Models
{
    public class PostDataModel
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string title { get; set; }
        public string body { get; set; }


        public List<PostDataModel> GetPostDatas()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            //we need to set the data format, JSON, every browser has a differnt data format, eg chrome has XML, IE has JSON, old ID has binary

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var callService = client.GetAsync(url);

            var response = callService.Result; //we need to check if it is a success or failure
            List<PostDataModel> resultData = new List<PostDataModel>();
            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsAsync<List<PostDataModel>>();
                read.Wait();
                resultData = read.Result;
            }
            else
            {
                throw new Exception("Call failed, please contact admin");
            }

            return resultData;


        }
    }
}
