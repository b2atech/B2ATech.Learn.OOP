using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2ATech.Learn.OOP
{
    public class ConsoleHelper
    {
        //Demonstration of Static Methos
        public static void PrintSectionHeader(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine("==================================================================");
            Console.WriteLine();
        }
    }
}
