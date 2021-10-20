using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int ratePerHr = 20;
            int empHr = 0;
            
            int Workingday = 20;
            int PartTime = 0;
            int FullTime = 0;
            int Absent = 0;
            int TotalWorkingHr = 0;
            for (int i = 1; i <= Workingday; i++) {
                Random num = new Random();
                int numGen = num.Next(0, 3);
                switch (numGen)
                {
                    case 0:
                        empHr = 8;
                        FullTime++;
                        
                        break;
                    case 1:
                        empHr = 4;
                        PartTime++;
                        break;
                    default:
                        empHr = 0;
                        Absent++;
                        break;

                            
                }
              
            }


            Console.WriteLine("Has Worked Full Time: "+FullTime+"   Has Worked Part Time: "+PartTime+  "  Was Absent this days: "+Absent);

            int MonthlyWage = ((FullTime*8)+(PartTime*4)+(Absent*0))*ratePerHr;
            Console.WriteLine("The Monthly wage of month is  " + MonthlyWage);
        }
    }
}
