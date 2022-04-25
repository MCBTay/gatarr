using Gatarr.Models;
using Gatarr.Models.Sonarr;

namespace Gatarr.Services
{
    public interface ISonarrService
    {
        Task<HttpResponseMessage> GetLog();
        Task<List<Series>> GetSeries();
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
    }
}
