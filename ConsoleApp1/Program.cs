using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int ratePerHr = 20;
            int empHr = 0;
            
            int Workingday = 30;
            int PartTime = 0;
            int FullTime = 0;
            int Absent = 0;
            int TotalWorkingHr = 0;
            int nTotalWorkingHr = 0;
            int i = 1;
            while( (i <= Workingday) && (nTotalWorkingHr<=100)) {
                Random num = new Random();
                int numGen = num.Next(0, 3);
                switch (numGen)
                {
                    case 0:
                        empHr = 8;
                        FullTime++;
                        TotalWorkingHr = TotalWorkingHr + empHr;
                        break;
                    case 1:
                        empHr = 4;
                        PartTime++;
                        TotalWorkingHr = TotalWorkingHr + empHr;

                        break;
                    default:
                        empHr = 0;
                        TotalWorkingHr = TotalWorkingHr + empHr;

                        Absent++;
                        break;

                            
                }
                nTotalWorkingHr = TotalWorkingHr;
                i++;
            }

            Console.WriteLine(TotalWorkingHr);
            Console.WriteLine("Has Worked Full Time: "+FullTime+"   Has Worked Part Time: "+PartTime+  "  Was Absent this days: "+Absent);

            int MonthlyWage = ((FullTime*8)+(PartTime*4)+(Absent*0))*ratePerHr;
            Console.WriteLine("The Monthly wage of month is..  " + MonthlyWage);
        }
    }
}
