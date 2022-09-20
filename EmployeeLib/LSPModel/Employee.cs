using System;

namespace EmployeeLib.LSPModel
{
    public abstract class Employee : IEmployee, ISuperVisor, ISalaryCalculator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEmployee Manager { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
        
        public virtual void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }
        
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
