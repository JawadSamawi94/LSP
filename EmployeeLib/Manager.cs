﻿using EmployeeLib.LSPModel;

namespace EmployeeLib
{
    public class Manager : Employee, IManager<CEO>
    {
        public IEmployee SuperVisor { get; set; }

        public void AssignManager(CEO superVisor)
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
