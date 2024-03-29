﻿using Gatarr.Models.Radarr;

namespace Gatarr.Services
{
    public interface IRadarrService : IArrService
    {
        Task<List<MovieResource>> GetMovies();
        Task<MovieResource> GetMovie(string id);
        Task<List<Credit>> GetCredits(string id);
        Task<List<MovieFile>> GetFiles(string id);
        Task<List<MovieHistory>> GetHistory(string id);
        Task<List<ReleaseResource>> GetReleases(string id);
    }

    public class RadarrService : ArrService, IRadarrService
    {
        public RadarrService(
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory)
            : base(configuration, httpClientFactory, "Radarr")
        {

        }

        public override string GetApiVersion()
        {
            return "v3";
        }

        public override async Task<bool> TestConnection()
        {
            try
            {
                using var response = await HttpClient.GetAsync("health");

                if (response?.Content == null || !response.IsSuccessStatusCode)
                {
                    return false;
                }

                var test = await response.Content.ReadAsStringAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
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

        public async Task<List<MovieFile>> GetFiles(string movieId)
        {
            var movieFiles = new List<MovieFile>();

            var response = await HttpClient.GetAsync($"movieFile?movieId={movieId}");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return movieFiles;
            }

            movieFiles = await response.Content.ReadFromJsonAsync<List<MovieFile>>();

            return movieFiles ?? new List<MovieFile>();
        }

        public async Task<List<MovieHistory>> GetHistory(string movieId)
        {
            var history = new List<MovieHistory>();

            var response = await HttpClient.GetAsync($"history/movie?movieId={movieId}");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return history;
            }

            history = await response.Content.ReadFromJsonAsync<List<MovieHistory>>();

            return history ?? new List<MovieHistory>();
        }

        public async Task<List<ReleaseResource>> GetReleases(string movieId)
        {
            var releases = new List<ReleaseResource>();

            var response = await HttpClient.GetAsync($"release?movieId={movieId}");

            if (response?.Content == null || !response.IsSuccessStatusCode)
            {
                return releases;
            }

            releases = await response.Content.ReadFromJsonAsync<List<ReleaseResource>>();

            return releases ?? new List<ReleaseResource>();
        }
    }
}
