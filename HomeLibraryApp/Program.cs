using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibraryApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int frame = 0;
            string uiSelection = "- -";
            
            while (uiSelection != "8")
            {
                Console.WriteLine($"Frame = {frame}");
                Console.WriteLine($"UI Selection = {uiSelection}\n");
                UI.PrintWelcomeMessage();
                UI.PrintHomeMenu();
                uiSelection = Console.ReadLine();





                Console.Clear();
                frame++;
            }
            if (uiSelection == "8")
            {
                Environment.Exit(0);
            }
        }
    }
}