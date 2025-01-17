using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagement.Controllers;
using MovieManagement.Views;

namespace MovieManagement.Framework
{
    internal class Router
    {
        private static MainControllers mainController = new MainControllers();

        public static void Forward(string route, MainView mainView) => mainController.ExecuteCommand(route, mainView: mainView);
    }
}
