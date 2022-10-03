using EmployeeLib.LSPModel;
using System;

namespace EmployeeLib
{
    public abstract class Employee : IEmployee, ISalaryCalculator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }

    }
}
