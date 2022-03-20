
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class WageComputation
    {
        const int fullTime = 1,
                  partTime = 2,
                   absent = 0,
                   ratePerHr = 20,
                   fullTimeHrs = 8,
                   partTimeHr = 4;
        public void CalculateEmpWage()
        {
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            
            if (empCheck == fullTime)
            {
                Console.WriteLine("Employee is present fullTime");
                int dailyEmpWage = fullTimeHrs  * ratePerHr ;
                Console.WriteLine("EmpWage:" +dailyEmpWage);
            }
            else if (empCheck == partTime)
            {
                Console.WriteLine("Employee is present partTime");
                int dailyEmpWage = partTimeHr * ratePerHr;
                Console.WriteLine("EmpWage:"+ dailyEmpWage);

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            
        }

    }
}

