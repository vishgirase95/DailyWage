using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int numGen = num.Next(0,3);
            int ratePerHr = 20;
            int empHr = 0;
            switch (numGen)
            {
                case 0:
                    empHr = 8;
                    break;
                case 1:
                    empHr = 4;
                    break;
                default:
                    empHr = 0;
                    break;



            }
                
               

            int dailyWage = empHr * ratePerHr;
            Console.WriteLine("The daily wage of  emp is " + dailyWage);
        }
    }
}
