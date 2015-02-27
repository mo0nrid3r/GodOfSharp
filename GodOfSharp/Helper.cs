using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodOfSharp
{
    public static class Helper
    {
        public static void PrintResult(string description, object value)
        {
            PrintResult(description, () => Console.WriteLine(value));
        }

        public static void PrintResult(string description, Action printFunction)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(description);
            Console.ResetColor();
            printFunction();
        }
    }
}
