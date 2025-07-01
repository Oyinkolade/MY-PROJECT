using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting number:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number:");
            int B = Convert.ToInt32(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && i > 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
