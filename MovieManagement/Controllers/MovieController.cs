using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagement.Models;
using MovieManagement.Repositories;
using MovieManagement.Views;

namespace MovieManagement.Controllers
{
    internal class MovieController
    {
        private MovieRepository movieRepository = new MovieRepository();
        private MovieView movieView = new MovieView();

        public void AddMovie(Movie movie)
        {
            movieRepository.Add(movie);
        }

        public void ListMovies()
        {
            var movies = movieRepository.GetAll();
            movieView.DisplayMovies(movies);
        }
        public void AddMovie()
        {
            Console.Write("Enter movie ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Enter movie name: ");
                string name = Console.ReadLine();

                Console.Write("Enter movie length (in minutes): ");
                if (int.TryParse(Console.ReadLine(), out int length))
                {
                    Console.Write("Enter year of production: ");
                    if (int.TryParse(Console.ReadLine(), out int year))
                    {
                        Console.Write("Enter movie description: ");
                        string description = Console.ReadLine();

                        Movie newMovie = new Movie(id, name, length, year, description);
                        movieRepository.Add(newMovie);
                        Console.WriteLine($"Movie '{name}' added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid year. Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid length. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid number.");
            }
        }

        public void RemoveMovie()
        {
            Console.Write("Enter movie ID to remove: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                movieRepository.Remove(id);
                Console.WriteLine($"Movie with ID {id} removed.");
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid number.");
            }
        }
    }
}
