using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class ayOfWeek
    {
        int year;
        int month;
        int day;

        public static void DayOfWeek()
        {

            int x = 0;
            int y0 = 0;
            int m0 = 0;
            int d0;
            Console.WriteLine("Enter Year of birthday");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of birthday");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of birthday Now");
            int day = int.Parse(Console.ReadLine());


            y0 = year - (14 - month) / 12;

            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

            m0 = month + 12 * ((14 - month) / 12) - 2;

            d0 = (day + x + 31 * m0 / 12) % 7;


            switch (d0)
            {
                case 0:
                    Console.WriteLine("its sunday");
                    break;
                case 1:
                    Console.WriteLine("its monday");
                    break;
                case 2:
                    Console.WriteLine("its Tuesday");
                    break;
                case 3:
                    Console.WriteLine("its Wednesday");
                    break;
                case 4:
                    Console.WriteLine("its Thrusday");
                    break;
                case 5:
                    Console.WriteLine("its Friday");
                    break;
                case 6:
                    Console.WriteLine("its Satarday");
                    break;


            }
            Console.WriteLine("day is " + d0);


        }
    }
}
