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
        private int movieIdToRemove;

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

        public void RemoveMovie(int id)
        {
            movieRepository.Remove(id);
        }

        public void RequestRemove()
        {
            Console.Write("Enter the ID of the movie you want to remove: ");
            if (int.TryParse(Console.ReadLine(), out movieIdToRemove))
            {
                Console.WriteLine($"Movie with ID {movieIdToRemove} has been identified for removal.");
                Console.WriteLine("Type 'confirmremove' to proceed.");
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid number.");
            }
        }

        public void ConfirmRemove()
        {
            if (movieIdToRemove <= 0)
            {
                Console.WriteLine("No valid movie ID to remove. Please request removal first.");
                return;
            }

            Console.Write($"Are you sure you want to remove the movie with ID {movieIdToRemove}? (yes/no): ");
            string confirmation = Console.ReadLine();
            if (confirmation.ToLower() == "yes")
            {
                RemoveMovie(movieIdToRemove);
                Console.WriteLine("Movie removed successfully.");
                movieIdToRemove = 0; 
            }
            else
            {
                Console.WriteLine("Removal cancelled.");
                movieIdToRemove = 0;
            }
        }
    }
}
