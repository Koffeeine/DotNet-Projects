using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagement.Models;

namespace MovieManagement.Views
{
    internal class MovieView
    {
        public void DisplayMovies(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Id}: {movie.Name} [{movie.Length} min] ({movie.YearOfProduction}) - {movie.Description}");
            }
        }

        public void DisplayMovieDetails(Movie movie)
        {
            Console.WriteLine($"Name: {movie.Name}\nLength: {movie.Length} min\nYear: {movie.YearOfProduction}\nDescription: {movie.Description}");
        }
    }
}
