namespace Gatarr.Services
{
    public interface IRadarrService
    {
        Task<HttpResponseMessage> GetLog();
    }

    public class RadarrService : IRadarrService
    {
        private readonly HttpClient _httpClient;

        public RadarrService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetLog()
        {
            return await _httpClient.GetAsync("log");
        }
    }
}
