using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class PartTimeWage
    {
        public static void ToCalculate_EmpWage()
        {
            int Is_FullTime = 1;
            int Is_PartTime = 2;
            int EmpWage_PerHr = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == Is_FullTime)
            {
                empHrs = 8;
            }
            else if (empCheck == Is_PartTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EmpWage_PerHr;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
