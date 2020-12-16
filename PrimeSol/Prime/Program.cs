using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {

        static void Main(string[] args)
        {
            bool notPrime = false;
            int j;

            Console.WriteLine("Enter your min?");
            int min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your max");
            int max = Int32.Parse(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }

                if (!notPrime)
                    Console.Write($"{j}");
                else
                    notPrime = false;
            }

            Console.ReadLine();
        }
    }
}
