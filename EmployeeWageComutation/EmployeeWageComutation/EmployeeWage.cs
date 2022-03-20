
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class WageComputation
    {
        const int present = 1,
                   absent = 0,
                   ratePerHr = 20, 
                   empWorkingHrs = 8;
        public void CalculateEmpWage()
        {
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            
            if (empCheck == present)
            {
                Console.WriteLine("Employee is present");
                int dailyEmpWage = empWorkingHrs  * ratePerHr ;
                Console.WriteLine("dailyEmpWage:" +dailyEmpWage);
            }
            else 
            {
                Console.WriteLine("Employee is absent");
            }
            
        }

    }
}

