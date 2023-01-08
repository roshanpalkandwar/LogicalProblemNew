using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class temprectureC
    {
        public static void TempretureC()
        {
            Console.WriteLine("Enter Option 1 to convert into celsious and 2 for Fahrenheit: ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value you want ot convert: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                int result = (input * 9 / 5) + 32;
                Console.WriteLine(input + "Celsius to fahrenheit is " + result);
            }
            else
            {
                int result = (input - 32) * 5 / 9;
                Console.WriteLine(input + " fahrenheit to celsius is " + result);

            }
        }
    }
}
