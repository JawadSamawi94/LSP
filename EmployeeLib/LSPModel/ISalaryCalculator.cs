namespace EmployeeLib.LSPModel
{
    public interface ISalaryCalculator
    {
        public decimal Salary { get; set; }
        public void CalculatePerHourRate(int rank);
    }
}
