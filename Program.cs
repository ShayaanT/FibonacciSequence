using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your desired value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int prev = 0;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(first);
                
                if (first == 0)
                {
                    first = 1;

                }

                else
                {
                    int second = first;
                    first = first + prev;
                    prev = second;

                }
                
            }
            Console.ReadLine();
        }
    }
}
