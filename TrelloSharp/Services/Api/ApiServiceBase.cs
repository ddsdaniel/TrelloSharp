using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace TrelloSharp.Services.Api
{
    public abstract class ApiServiceBase : ServiceBase
    {
        public string UrlBase => "https://api.trello.com/1";        
        public string Key { get; private set; }
        public string Token { get; private set; }
        private readonly HttpClient _httpClient;

        protected ApiServiceBase(string key, string token)
        {            
            Key = key;
            Token = token;
            _httpClient = new HttpClient();
        }

        internal async Task<T> Get<T>(string url)
        {
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)            
                return response.Content.ReadAsAsync<T>().Result;

            throw new Exception(response.StatusCode.ToString());
        }
    }
}
