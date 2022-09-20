namespace EmployeeLib.LSPModel
{
    public interface ISuperVisor
    {
        public IEmployee Manager { get; set; }

        public void AssignManager(IEmployee manager);
        public void GeneratePerformanceReview();
    }
}
