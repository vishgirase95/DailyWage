using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int numGen = num.Next(0,2);
            int ratePerHr = 20;
            int empHr = 0;
            if (numGen == 1)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            int dailyWage = empHr * ratePerHr;
            Console.WriteLine("The daily wage of  emp is Hello " + dailyWage);
        }
    }
}
