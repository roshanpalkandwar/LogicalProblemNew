using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class fibonaciSeries
    {
        public static void FibonaciSeries()
        {
            int a = 0, b = 1;


            Console.WriteLine("enter the number for limit of series");
            int n = Convert.ToInt32(Console.ReadLine());
            int c;
            for (int i = 1; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(+c);
                a = b;
                b = c;


            }


        }
    }
}
