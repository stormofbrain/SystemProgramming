using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace dz3
{
    class Program
    {
        public static int miliseconds = 0;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1000, 4000);
            Thread.Sleep(r);
            Method_2();

        }
        public static void Method_1(object a)
        {
            miliseconds += 1;
            // Console.WriteLine(miliseconds);
        }
        public static void Method_2()
        {
            try
            {
                TimerCallback t = new TimerCallback(Method_1);
                Timer tmr = new Timer(t);
                ConsoleKeyInfo cki = new ConsoleKeyInfo();

                tmr.Change(0, 1);
                Console.WriteLine("Press UP Arrow");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    tmr.Dispose();
                    if (miliseconds > 300)
                    {
                        Console.WriteLine("Noob!!!");
                    }
                }
                Console.WriteLine("Res = {0} miliseconds", miliseconds);
                while (true)
                {
                    if (cki.Key == ConsoleKey.UpArrow)
                    {
                        break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
