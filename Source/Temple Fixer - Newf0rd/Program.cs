using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple_Fixer___Newf0rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hang on while I fix your broken client.");
            try
            {
                System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Roblox\\GlobalBasicSettings_13.xml");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Try it now!");
                Console.Read();
            }
            catch
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("Unknown error while fixing. Try with elevated permissions. (Running as admin.)");
                Console.Read();
            }
        }
    }
}
