using Gatarr.Models.Radarr;

namespace Gatarr.Services
{
    public interface IRadarrService
    {
        Task<HttpResponseMessage> GetLog();

        Task<List<MovieResource>> GetMovies();
    }

    public class RadarrService : IRadarrService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public RadarrService(
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;

            var host = _configuration["Radarr:Host"];
            var port = _configuration["Radarr:Port"];
            var apiKey = _configuration["Radarr:ApiKey"];

            //var host = "192.168.1.222";
            //var port = "7878";
            //var apiKey = "a99bd0920631402ca9f7f86bee1c1e12";

            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri($"http://{host}:{port}/api/v3/");
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }

        public async Task<HttpResponseMessage> GetLog()
        {
            return await _httpClient.GetAsync("log");
        }

        public async Task<List<MovieResource>> GetMovies()
        {
            var movies = new List<MovieResource>();

            var response = await _httpClient.GetAsync("movie");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return new List<MovieResource>();
            }

            return await response.Content.ReadFromJsonAsync<List<MovieResource>>();
        }
    }
}
