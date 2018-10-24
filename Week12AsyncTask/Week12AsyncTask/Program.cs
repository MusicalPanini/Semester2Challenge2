using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12AsyncTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var stuff = await FindPrime(250000);
            var things = await FindPrime(400000);
            Console.WriteLine(stuff);
            Console.WriteLine(things);
            Console.ReadLine();
        }

        public static async Task<long> FindPrime(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1; // to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }
    }
}
