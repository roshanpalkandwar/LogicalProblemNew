using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class monthlyPayment
    {
        public static void Monthpayment()
        {
            Console.WriteLine("Enter amount of Loan");
            int LoanAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount Percentage Rate");
            double PercRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter No of year you want to pay");
            int year = Convert.ToInt32(Console.ReadLine());

            double r = (PercRate / (12 * 100));
            double Power = (1 - Math.Pow((1 + r), (-12 * year)));
            double c = (LoanAmount * r / Power);

            Console.WriteLine("Monthly Payment of  " + c);
        }
    }
}
