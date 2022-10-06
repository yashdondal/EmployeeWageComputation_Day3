using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
   public static class MonthEmpWage
   {
         public static void ToCalculate_EmpWage()
         {
               public const int Part_Time = 1;
        public const int Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int No_of_Working_Days = 2;
      //static void Main(string[]args)
        public static void Monthlywages()
            {
            int empHrs = 0, empWages =0, totalEmpWages=0;
            for(int days=0; days <=No_of_Working_Days; days++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck )
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
                empWages = empHrs * Emp_Rate_Per_Hour;
                totalEmpWages += empWages;
                Console.WriteLine("Emp Wage : " +empWages); 
            }
            Console.WriteLine("Total Emp Wage:" +totalEmpWages);
        }
   }
}
