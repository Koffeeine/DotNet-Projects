using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Views
{
    internal class MainView
    {
        public void HelpView()
        {
            Console.WriteLine("=== HELP ===");
            Console.WriteLine("list - Shows Movie List");
            Console.WriteLine("add - Add a movie");
            Console.WriteLine("help - Shows guide");
            Console.WriteLine("clear - Clears console");
            Console.WriteLine("remove - Removes a movie");
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
