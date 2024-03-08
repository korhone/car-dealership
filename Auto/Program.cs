using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.view;

namespace CarDealership
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu MainWindow = new MainMenu();
            MainWindow.ShowDialog();
        }
    }
}
