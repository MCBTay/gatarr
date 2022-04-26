using Gatarr.Models.Radarr;

namespace Gatarr.Services
{
    public interface IRadarrService
    {
        Task<HttpResponseMessage> GetLog();
        Task<List<MovieResource>> GetMovies();
        Task<MovieResource> GetMovie(string id);
        Task<List<Credit>> GetCredits(string movieId);
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
                return movies;
            }

            movies = await response.Content.ReadFromJsonAsync<List<MovieResource>>();

            return movies ?? new List<MovieResource>();
        }

        public async Task<MovieResource> GetMovie(string id)
        {
            var movie = new MovieResource();

            var response = await HttpClient.GetAsync($"movie/{id}");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return movie;
            }

            movie = await response.Content.ReadFromJsonAsync<MovieResource>();

            return movie ?? new MovieResource();
        }

        public async Task<List<Credit>> GetCredits(string movieId)
        {
            var credits = new List<Credit>();

            var response = await HttpClient.GetAsync($"credit?movieId={movieId}");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return credits;
            }

            credits = await response.Content.ReadFromJsonAsync<List<Credit>>();

            return credits ?? new List<Credit>();
        }
    }
}
