namespace Gatarr.Services
{
    public class ArrService
    {
        protected readonly IConfiguration Configuration;
        protected readonly HttpClient HttpClient;

        protected readonly string Name;

        protected readonly string Host;
        protected readonly string Port;
        protected readonly string ApiKey;

        protected ArrService(
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory,
            string name)
        {
            Configuration = configuration;
            Name = name;

            Host = Configuration[$"{Name}:Host"];
            Port = Configuration[$"{Name}:Port"];
            ApiKey = Configuration[$"{Name}:ApiKey"];

            HttpClient = httpClientFactory.CreateClient();
            HttpClient.BaseAddress = new Uri($"http://{Host}:{Port}/api/v3/");
            HttpClient.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);
        }
    }
}
