using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int intEntered;
                Console.WriteLine("Please Enter Number Between 0 and 100");
                Console.WriteLine();
                intEntered = Convert.ToInt16(Console.ReadLine());
                do
                {
                    if (intEntered == 42)
                    {
                        Console.WriteLine("Correct");
                        Console.WriteLine("Press Any Key to Exit");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                        Console.WriteLine("Please Enter Number Between 0 and 100");
                        Console.WriteLine();
                        intEntered = Convert.ToInt16(Console.ReadLine());
                    }
                }
                while (intEntered == 42);
            }
        }
    }
}
