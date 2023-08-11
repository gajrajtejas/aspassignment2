// Include necessary libraries and models
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MovieInfoApp.Models;

// Namespace for the services
namespace MovieInfoApp.Services
{
    // Public class for MovieService
    public class MovieService
    {
        // Constant string holding the path of the JSON file
        private const string JsonFileName = "wwwroot/data/Movies.json";

        // Method to get a list of Movies
        public List<MovieModel> GetGames()
        {
            // Open and read the JSON file
            using var jsonFileReader = File.OpenText(JsonFileName);
            // Deserialize the JSON to a list of Movie models
            return JsonSerializer.Deserialize<List<MovieModel>>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    // Case-insensitive deserialization
                    PropertyNameCaseInsensitive = true
                });
        }
    }
}