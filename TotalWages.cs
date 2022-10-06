using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
public static class TotalWages
    {
        public const int Part_Time = 1;
        public const int Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int NUM_OF_Working_Days = 2;
        public const int Max_Hrs_In_Month = 10;
        //static void Main(string[]args)
        public static void Max_Month_Wages()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < NUM_OF_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Part_Time:
                        empHrs = 4;
                        break;
                    case Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
        }
    }
}
