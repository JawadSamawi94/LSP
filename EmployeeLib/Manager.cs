using EmployeeLib.LSPModel;
using System;

namespace EmployeeLib
{
    public class Manager : Employee, ISuperVisor
    {
        public IEmployee SuperVisor { get; set; }

        public void AssignManager(IEmployee superVisor)
        {
            SuperVisor = superVisor;
        }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }
    }
}
