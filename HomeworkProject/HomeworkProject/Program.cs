using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee {Name = "Alex", Salary = 900},
            new Employee {Name = "Ivan", Salary = 1200},
            new Employee {Name = "Max", Salary = 4000}
        };

            var builder = new EmployeeReportBuilder(employees);
            var director = new EmployeeReportDirector(builder);

            director.Build();

            var report = builder.GetReport();

            Console.WriteLine(report);
            Console.ReadKey();

        }
    }
}
