using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GodOfSharp.Parallel
{
    public class Deadlock
    {
        private static object _PrimaryObject = new object();
        private static object _SecondaryObject = new object();

        private static void StraightTask()
        {
            lock (_PrimaryObject)
            {
                Thread.Sleep(1000);
                lock (_SecondaryObject)
                {
                    Console.WriteLine("Straight!");
                }
            }
        }

        private static void ReverseTask()
        {
            lock (_SecondaryObject)
            {
                Thread.Sleep(1000);
                lock (_PrimaryObject)
                {
                    Console.WriteLine("Reverse!");
                }
            }
        }

        public static void Process()
        {
            Console.WriteLine("This code never ends");

            var th1 = new Thread(StraightTask);
            var th2 = new Thread(ReverseTask);
            //th1.Start();
            th2.Start();
            StraightTask();

            
        }
    }
}
