using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public static class PresentAbsent
    {
        public static void EmployeeCheckAttendance()
        {
            int Is_FullTime = 1;
            Random random = new Random();
            int emplCheck = random.Next(0, 2);

            if (emplCheck == 1)
            {
                Console.WriteLine("Empolyee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
    
