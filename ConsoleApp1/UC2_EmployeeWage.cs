using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UC2_EmployeeWage
    {
        public static void EmployeeWage()
        {
            Console.WriteLine("\nUC2");
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
            Console.ReadKey();
        }
    }
}
