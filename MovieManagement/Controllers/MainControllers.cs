using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagement.Views;

namespace MovieManagement.Controllers
{
    internal class MainControllers
    {
        private MovieController movieController = new MovieController();

        public void ExecuteCommand(string command, MainView mainView)
        {
            switch (command.ToLower())
            {
                case "help":
                    mainView.HelpView();
                    break;
                case "add":
                    movieController.AddMovie();
                    break;
                case "list":
                    movieController.ListMovies();
                    break;
                case "remove":
                    movieController.RemoveMovie();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                case "clear":
                    mainView.Clear();
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
    }
}
