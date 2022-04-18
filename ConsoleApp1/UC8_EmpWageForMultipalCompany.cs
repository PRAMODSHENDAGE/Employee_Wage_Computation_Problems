using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UC8_EmpWageForMultipalCompany
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int ComputeEmpwage(string company, int Emprateperhour, int numofworkingdays, int maxhourspermonth)
        {
            Console.WriteLine("\nUC8");
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxhourspermonth && totalWorkingDays < numofworkingdays)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpwage = totalEmpHrs * Emprateperhour;
            Console.WriteLine("Total Emp Wage for company: " + company + "is:" + totalEmpwage);
            Console.ReadKey();
            return totalEmpwage;
        } 
            private static void Main(string[] args)
            {
            ComputeEmpwage("DMart", 20, 2, 10);
            ComputeEmpwage("Reliance", 10, 4, 20);
            }
    }
}