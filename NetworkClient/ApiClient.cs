using System.Net.Http;
using System.Threading.Tasks;

namespace NetworkClient
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetWeatherAsync()
        {
            // Use HTTP (we avoided HTTPS cert issues)
            var url = "http://localhost:5123/weatherforecast";

            return await _httpClient.GetStringAsync(url);
        }
    }
}
