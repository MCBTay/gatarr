using Gatarr.Models;
using Gatarr.Models.Sonarr;

namespace Gatarr.Services
{
    public interface ISonarrService
    {
        Task<HttpResponseMessage> GetLog();
        Task<List<Series>> GetSeries();
        Task<Series> GetSeries(string id);
        Task<List<Episode>> GetEpisodes(string id);
    }

    public class SonarrService : ArrService, ISonarrService
    {
        public SonarrService(
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory)
            : base(configuration, httpClientFactory, "Sonarr")
        {

        }

        public async Task<HttpResponseMessage> GetLog()
        {
            return await HttpClient.GetAsync("log");
        }

        public async Task<List<Series>> GetSeries()
        {
            var series = new List<Series>();

            var response = await HttpClient.GetAsync("series");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return series;
            }

            series = await response.Content.ReadFromJsonAsync<List<Series>>();

            return series ?? new List<Series>();
        }

        public async Task<Series> GetSeries(string id)
        {
            var series = new Series();

            var response = await HttpClient.GetAsync($"series/{id}");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return series;
            }

            series = await response.Content.ReadFromJsonAsync<Series>();

            return series ?? new Series();
        }

        public async Task<List<Episode>> GetEpisodes(string id)
        {
            var episodes = new List<Episode>();

            var response = await HttpClient.GetAsync($"episode?seriesId={id}");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return episodes;
            }

            episodes = await response.Content.ReadFromJsonAsync<List<Episode>>();

            return episodes ?? new List<Episode>();
        }
    }
}
