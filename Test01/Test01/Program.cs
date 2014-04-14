using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string message3 = "";
                string message5 = "";
                if (i % 3 == 0)
                {
                    message3 = "-Support";
                }
                if (i % 5 == 0)
                {
                    if (message3 == "")
                    {
                        message5 = "-Training";
                    }
                    else
                    { message5 = "Training"; }


                }
                Console.WriteLine(i + message3 + message5);                              
            }
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadLine();

        }
    }
}
