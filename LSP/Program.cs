using System;
using EmployeeLib;
using EmployeeLib.LSPModel;

namespace LSP {
    internal class Program {
        static void Main(string[] args) {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            Console.WriteLine($"{ accountingVP.FirstName }'s salary is ${ accountingVP.Salary }/hour.");

            Employee emp = new CEO();

            emp.FirstName = "Tom";
            emp.LastName = "Lally";
            emp.CalculatePerHourRate(2);

            //emp.AssignManager(accountingVP); // this can't happen 
            accountingVP.AssignManager(emp);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
