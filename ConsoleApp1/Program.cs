using System;

namespace ConsoleApp1
{
    class Program
    {

        public static int empHr = 0;
        public static int Workingday = 30;
        public static int ratePerHr = 20;
        public static int PartTime = 0;

        public static int FullTime = 0;
        public static int Absent = 0;
        public static int TotalWorkingHr = 0;
        public static int nTotalWorkingHr = 0;
        public static int i = 1;

        public static int EmpWage()
        {

            while ((i <= Workingday) && (nTotalWorkingHr <= 100))
            {
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
            Console.WriteLine("Has Worked Full Time: " + FullTime + "   Has Worked Part Time: " + PartTime + "  Was Absent this days: " + Absent);

            int MonthlyWage = ((FullTime * 8) + (PartTime * 4) + (Absent * 0)) * ratePerHr;
            Console.WriteLine("The monthly wage will be "+ MonthlyWage);
            return MonthlyWage;
        }
        static void Main(string[] args)
        {
           EmpWage();
        }
    }
}
