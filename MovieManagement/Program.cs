using System;
using MovieManagement.Framework;
using MovieManagement.Views;

namespace MovieManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MOVIE MANAGEMENT ===");

            MainView mainView = new MainView();

            while (true)
            {
                Console.Write(">>> ");
                var route = Console.ReadLine();
                Router.Forward(route, mainView);
            }
        }
    }
}