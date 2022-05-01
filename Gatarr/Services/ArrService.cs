namespace Gatarr.Services
{
    public interface IArrService
    {
        string Name { get; set; }
        string Host { get; set; }
        string Port { get; set; }
        string ApiKey { get; set; }

        void ConfigureHttpClient(string? host, string? port, string? apiKey, bool? useHttps);
        Task<bool> TestConnection();
    }

    public abstract class ArrService : IArrService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        protected readonly IConfiguration Configuration;
        protected HttpClient HttpClient;

        public string Name { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string ApiKey { get; set; }

        protected ArrService(
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory,
            string name)
        {
            _httpClientFactory = httpClientFactory;

            Configuration = configuration;
            Name = name;
            
            ConfigureHttpClient();
        }

        public void ConfigureHttpClient(string? host = null, string? port = null, string? apiKey = null, bool? useHttps = null)
        {
            Host = host ?? Configuration[$"{Name}:Host"];
            Port = port ?? Configuration[$"{Name}:Port"];
            ApiKey = apiKey ?? Configuration[$"{Name}:ApiKey"];

            bool.TryParse(Configuration[$"{Name}:UseHttps"], out var _useHttpsConfig);
            var useHttpsFinal = useHttps ?? _useHttpsConfig;
            var protocol = useHttpsFinal ? "https" : "http";

            HttpClient = _httpClientFactory.CreateClient();

            HttpClient.BaseAddress = new Uri($"{protocol}://{Host}:{Port}/api/v3/");
            HttpClient.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);
            HttpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        public abstract Task<bool> TestConnection();
    }
}
