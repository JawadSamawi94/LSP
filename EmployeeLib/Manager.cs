using EmployeeLib.LSPModel;

namespace EmployeeLib
{
    public class Manager : Employee, IManager<CEO>
    {
        public CEO EmployeeManager { get; set; }

        public void AssignManager(CEO employeeManager)
        {
            EmployeeManager = employeeManager;
        }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }
    }
}
