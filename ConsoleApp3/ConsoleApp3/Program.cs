using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string prompt = "Fly, but don't die";
            //string[] options = { "Option 1", "Option 2", "Option 3" };
            //Menu mainMenu = new Menu(prompt, options);
            //int selectedIndex = mainMenu.Run();
            //Console.ReadKey();

            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;

            Air newRess = new Air();
            newRess.Start();

        }
    }
}
