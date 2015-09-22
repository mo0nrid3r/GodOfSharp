using GodOfSharp.AutoProperty;
using GodOfSharp.Inheritance;
using GodOfSharp.Iterator;
using GodOfSharp.ObjectInitializer;
using GodOfSharp.ObjectType;
using GodOfSharp.Parallel;
using GodOfSharp.Tasks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace GodOfSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //Refactored
            //OverrideAutoProperty.Process();
            //PotatoRun.Process1();
            //PotatoRun.Process2();
            //PassParam.ProcessChangeString();
            //PassParam.ProcessChangeInt();
            //PassParam.ProcessChangeFooProperty();
            //PassParam.ProcessChangeFoo();
            //ObjectInit.Process();
            //Deadlock.Process();
            //Non-refactored
            //var e = Crypto.HashPassword("4qb4XgZDRL3zRZJ4");
            //Console.WriteLine(e);
            //AssignIncrement.Process();
            //AssignIncrement.HowMuch();
            //AsyncAwait.Process();
            var s = new DateTime(2015, 5, 5).ToShortDateString();
            sw.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed time: " + sw.Elapsed.TotalSeconds);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
