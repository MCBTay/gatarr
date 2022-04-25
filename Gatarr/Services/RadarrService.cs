using Gatarr.Models.Radarr;

namespace Gatarr.Services
{
    public interface IRadarrService
    {
        Task<HttpResponseMessage> GetLog();

        Task<List<MovieResource>> GetMovies();
    }

    public class RadarrService : ArrService, IRadarrService
    {
        public RadarrService(
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory)
            : base(configuration, httpClientFactory, "Radarr")
        {

        }

        public async Task<HttpResponseMessage> GetLog()
        {
            return await HttpClient.GetAsync("log");
        }

        public async Task<List<MovieResource>> GetMovies()
        {
            var movies = new List<MovieResource>();

            var response = await HttpClient.GetAsync("movie");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return new List<MovieResource>();
            }

            return await response.Content.ReadFromJsonAsync<List<MovieResource>>();
        }
    }
}
