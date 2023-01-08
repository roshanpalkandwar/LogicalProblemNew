using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class perfectNumber
    {
        public static void PerfectNumber()
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            int s = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    s = s + i;
                }
            }
            if (s == n)
            {
                Console.WriteLine("perfect number");
            }
            else
            {
                Console.WriteLine("not a perfect number");
            }
        }
    }
}
