using GodOfSharp.AutoProperty;
using GodOfSharp.Inheritance;
using GodOfSharp.Iterator;
using GodOfSharp.ObjectInitializer;
using GodOfSharp.ObjectType;
using GodOfSharp.Parallel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            
            AssignIncrement.Process();
            AssignIncrement.HowMuch();
            sw.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed time: " + sw.Elapsed.TotalSeconds);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
