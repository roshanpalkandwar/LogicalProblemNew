using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class toBinary
    {
        public static void Tobinary()
        {
            Console.WriteLine("enter the decimal number");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = " ";
            int t = a;
            while (t > 0)
            {
                int r = t % 2;
                t = t / 2;
                b = r + b;
            }
            Console.WriteLine("binary wquivalent of " + a + " is " + b);


        }
    }
}
