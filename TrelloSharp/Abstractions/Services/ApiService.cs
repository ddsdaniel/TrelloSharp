using System.Net.Http;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;

namespace TrelloSharp.Abstractions.Services
{
    public abstract class ApiService : Service
    {
        public string UrlBase => "https://api.trello.com/1";
        public string AppKey { get; private set; }
        public string UserToken { get; private set; }
        private readonly HttpClient _httpClient;
        private readonly ILogger<Service> _logger;

        protected ApiService(string appKey, string userToken, ILogger<Service> logger)
        {
            AppKey = appKey;
            UserToken = userToken;
            _logger = logger;

            var httpClientHandler = new HttpClientHandler
            {
                Proxy = null,
                UseProxy = false
            };
            _httpClient = new HttpClient(httpClientHandler);
            
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        internal async Task<T> Get<T>(string url)
        {
            _logger.LogTrace("[GET] {url}", url);

            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var viewModel = await response.Content.ReadAsAsync<T>();
                return viewModel;
            }

            throw new Exception(response.StatusCode.ToString());
        }

        internal async Task<TRetorno> PutStringContent<TRetorno>(string url, StringContent dado)
        {
            var response = await _httpClient.PutAsync(url, dado);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<TRetorno>();

            throw new Exception(response.StatusCode.ToString());
        }

        internal async Task<TRetorno> Put<TEnvio, TRetorno>(string url, TEnvio dado)
        {
            var response = await _httpClient.PutAsJsonAsync(url, dado);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<TRetorno>();

            throw new Exception(response.StatusCode.ToString());
        }

        internal async Task<TRetorno> Post<TEnvio, TRetorno>(string url, TEnvio dado)
        {
            var response = await _httpClient.PostAsJsonAsync(url, dado);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<TRetorno>();

            throw new Exception(response.StatusCode.ToString());
        }

        internal async Task<TRetorno> Post<TRetorno>(string url)
        {
            var response = await _httpClient.PostAsync(url, null);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<TRetorno>();

            throw new Exception(response.StatusCode.ToString());
        }

        internal async Task Post(string url)
        {
            await _httpClient.PostAsync(url, null);
        }
    }
}
