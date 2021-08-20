using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganisationConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee()
            {
                EmpId = 100,
                Name = "Peter",
                SalaryPerDay = 32.5,
                HRA = 12.3
            };

            double GS = E.GetSalary(3);
            Console.WriteLine("Gross salary of {0} is {1}", E.Name, GS);
            Console.ReadLine();
        }
    }
}
