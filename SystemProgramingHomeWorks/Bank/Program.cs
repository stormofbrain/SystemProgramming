using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParameterizedThreadStart threadStart = new ParameterizedThreadStart(func);
            //Thread thread = new Thread(threadStart);
            //List<object> objectsList = new List<object>();
            //objectsList.Add("hi");
            //objectsList.Add(" ");
            //objectsList.Add("I'm");
            //objectsList.Add(' ');
            //objectsList.Add('r');
            //objectsList.Add(0);
            //objectsList.Add("b");
            //objectsList.Add(1.000);
            //thread.Start(objectsList);

            Bank bnk = new Bank();
            bnk.Money = 3000;
            bnk.Name = "PrivatBank";
            bnk.Percent = 21;
            bnk.Money = 10000;
        }

        static void func(object obj)
        {
            List<object> list = ((IList<object>)obj).ToList();
            foreach (var v in list)
            {
                Console.Write(v.ToString());
            }
            Console.Write("\n\n");
        }
    }
}
