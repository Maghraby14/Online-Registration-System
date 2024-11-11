using System.Net.Http;

namespace BlazorApp1.HttpClientServices
{
    public class APIService
    {
        public HttpClient httpClient;

        public APIService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string GetBaseUrl()
        {
            return httpClient.BaseAddress.ToString();
        }
    }
}
