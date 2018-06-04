using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    WRITTEN BY: OYEFESO OLUWATUNMISE (BLAC_PANDA)
    DATE: JANUARY 2017
*/
namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n, limit\n");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int n = 0; n < limit; n++)
            {
                for (int r = 0; r <= n; r++)
                {
                    Console.Write("{0} ", combination(n, r));
                }
                Console.WriteLine("  ");
            }
            Console.ReadLine();
        }
        public static int FACTORIA(int n)
        {
            int fact = 1;
            if (n == 0)
                return 1;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }
        public static int combination(int n, int r)
        {
            if (n == 0)
                return 1;
            else
            {
                //P IS PERMUTATION
                int p = FACTORIA(n) / FACTORIA(n - r);
                int c = p / FACTORIA(r);
                return c;
            }
        }
    }
}