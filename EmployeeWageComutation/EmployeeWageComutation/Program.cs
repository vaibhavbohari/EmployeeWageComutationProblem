

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmployeeWage.monthlyEmployeeWage("PVP", 20, 20, 100);
            EmployeeWage.monthlyEmployeeWage("DMART", 30, 24, 140);
        }
    }
}

