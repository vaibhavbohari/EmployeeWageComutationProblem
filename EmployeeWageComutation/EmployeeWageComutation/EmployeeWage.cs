
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        const int fullTime = 1,
                  partTime = 2,
                   absent = 0,
                   ratePerHr = 20,
                   fullTimeHrs = 8,
                   partTimeHr = 4,
                   perMonthDays = 20;
        public void CalculateEmpWage()
        {
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            int empWage = 0;
            switch (empCheck)
            {
                case fullTime:
                    Console.WriteLine("Employee is Present fullTime");
                    empWage =perMonthDays *( ratePerHr * fullTimeHrs);
                    break;

                case partTime:
                    Console.WriteLine("Employee is Present partTime");
                    empWage = perMonthDays *(ratePerHr * partTimeHr);
                    break;
               
                default :
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            Console.WriteLine("Employee Wage Per Month :" + empWage);
        }    

    }
}
    
