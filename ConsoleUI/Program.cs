using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OPC stabds for "Open Closed Principle" - design pattern
// Closed for modification but Open for extension (in the production)
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new ExecutiveModel { FirstName = "Iyad", LastName = "Shobaki" },
                new ManagerModel { FirstName = "Tim", LastName = "Corey" },
                new PersonModel { FirstName = "Sue", LastName = "Storm"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();

        }
    }
}
