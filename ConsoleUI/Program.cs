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
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Iyad", LastName = "Shobaki", TypeOfEmployee = EmployeeType.Executive},
                new PersonModel { FirstName = "Tim", LastName = "Corey", TypeOfEmployee = EmployeeType.Manager},
                new PersonModel { FirstName = "Sue", LastName = "Storm"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();

        }
    }
}
