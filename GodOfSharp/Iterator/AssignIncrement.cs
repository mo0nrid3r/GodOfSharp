using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodOfSharp.Iterator
{
    public class AssignIncrement
    {
        public static void Process()
        {
            int c = 0;
            for (int i = 0; i < 100; i++)
            {
                c = i++;
            }
            Console.WriteLine(c);
        }

        public static void HowMuch()
        {
            int i = 5;
            i = ++i + ++i;
            Console.WriteLine(i);
        }
    }
}
