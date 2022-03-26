

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmployeeWage dMart = new EmployeeWage("DMart", 20, 20, 100);
            EmployeeWage pvp = new EmployeeWage("PVP", 25, 24, 160);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            pvp.computeEmpWage();
            Console.WriteLine(pvp.toString());
        }
    }
}