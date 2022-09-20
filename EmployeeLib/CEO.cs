using EmployeeLib.LSPModel;
using System;

namespace EmployeeLib
{
    public class CEO : Employee
    {

        public override void AssignManager(IEmployee manager)
        {
            throw new InvalidOperationException("The CEO has no manager.");
        }
    }
}
