using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodOfSharp.Tasks
{
    public class AsyncAwait
    {
        private static async Task Retry(Task t)
        {
            int cnt = 5;
            while (true)
            {
                try
                {
                    await t.ConfigureAwait(false);
                    return;
                }
                catch (Exception e)
                {
                    //Logger.ErrorException("Chunk Error", e);
                    Console.WriteLine("Chunk Error: " + e.Message);
                    Console.WriteLine("Chunk Inner error: " + (e.InnerException != null ? e.InnerException.Message : "null inner"));
                    if (cnt == 1)
                        Console.WriteLine(e.StackTrace);
                    //Logger.Info("Attempts remaining: " + cnt);
                    if (cnt < 1)
                        return;
                }
                cnt--;
                await Task.Delay(60000);
            }
        }

        public static void Process()
        {
            Console.WriteLine("Retrier");

            try
            {
                Retry(new Task(() => { throw new Exception("qq"); })).Wait();
            }
            catch (Exception e)
            {

            }
        }
    }
}
