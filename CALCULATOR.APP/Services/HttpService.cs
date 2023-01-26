using CALCULATOR.APP.Interface;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Text.Json;

namespace CALCULATOR.APP.Services
{
    public class HttpService : IHttpService
    {
        private HttpClient _httpClient;
        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<T> Post<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            string post = JsonSerializer.Serialize(value);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await sendRequest<T>(request);
        }

        private async Task<T> sendRequest<T>(HttpRequestMessage request)
        {
            using var response = await _httpClient.SendAsync(request);

            // throw exception on error response
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new Exception(error["message"]);
            }
            var resultOjbect = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(resultOjbect);
        }
    }
}
