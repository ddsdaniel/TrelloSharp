using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TrelloSharp.Entities;

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
            {
                return await response.Content.ReadAsStringAsync .ReadAsAsync<T>();
            }
            return product;

        }
    }
}
