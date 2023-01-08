using LogicalProblem;
using System.Diagnostics;
using System;

namespace Day6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to fobonaci series ");
            Console.WriteLine("chooes program\n1. fibonaci series\n2.find perfect number\n3.find prime number or not\n4.reverse a number\n5.coupan Number\n6.stop watch program\n7.Find the Fewest Notes to be returned for Vending Machine\n8.Day of week");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    fibonaciSeries.FibonaciSeries();
                    break;
                case 2:
                    perfectNumber.PerfectNumber();
                    break;
                case 3:
                    PrimeNumber.primeNumber();
                    break;
                case 4:
                    ReverseNumber.reverseNumber();
                    break;
                case 5:
                    coupanNumber.Coupon();
                    break;
                case 6:
                    StopWatch.Stopwatch();
                    break;
                case 7:
                    vedingMachineproblem.VedingMachineProblem();
                    break;
                case 8:
                    ayOfWeek.DayOfWeek();
                    break;

            }
        }
    }
}