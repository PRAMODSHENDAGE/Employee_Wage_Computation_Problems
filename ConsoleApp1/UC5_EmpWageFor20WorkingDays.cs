using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UC5_EmpWageFor20WorkingDays
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public static void EmpWageFor20Days()
        {
            Console.WriteLine("\nUC5");
            int empHrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalempwage += empWage;
                Console.WriteLine("Emp Wage = " + empWage);
            }
            Console.WriteLine("Total Emp Wage = " + totalempwage);
        }
    }
}
