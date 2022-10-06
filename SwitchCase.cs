using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class SwitchCase
    {
       public const int Is_Part_time = 1;
        public const int Is_Full_time = 2;
        public const int Emp_Rate_Per_Hour = 20;
       //static void Main(string[]args)
       public static void UsingSwitch()
        { 
            int empHrs = 0;
            int empwags = 0;
            Random rand = new Random();
            int empcheck = rand.Next(0, 3);
            switch(empcheck)
            {
                case Is_Part_time:
                    empHrs = 4;
                    break;
                case Is_Full_time:
                    empHrs = 8;
                    break;
            }
            empwags = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("emp wage= " + empwags);
        }
        
    }
}