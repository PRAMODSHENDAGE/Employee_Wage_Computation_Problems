using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UC9_EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string company;
        private int EmprateperHour;
        private int numofworkingdays;
        private int maxHourspermonth;
        private int totalEmpwage;
        public UC9_EmpWageBuilderObject(string company, int Emprateperhour, int numofworkingdays, int maxhourspermonth)
        {
            Console.WriteLine("\nUC9");
            this.company = company;
            this.EmprateperHour = Emprateperhour;
            this.numofworkingdays = numofworkingdays;
            this.maxHourspermonth = maxhourspermonth;
        }
        public void ComputeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHourspermonth && totalWorkingDays < this.numofworkingdays)
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
            totalEmpwage = totalEmpHrs * this.EmprateperHour;
            Console.WriteLine("Total EmpWage for Company: " + company + " is:" + totalEmpwage);
        }
        public string toString()
        {
            return "Total Emp Wage for Company: " + this.company + "is:" + this.totalEmpwage;
        }
   
    }
}