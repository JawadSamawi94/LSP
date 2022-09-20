namespace EmployeeLib.LSPModel
{
    public interface ISuperVisor
    {
        public IEmployee SuperVisor { get; set; } 
        // Manager renamed to supervisor because a class can't have a memeber with the same name
        // class Manager { public Manager }  X

        public void AssignManager(IEmployee manager);
        public void GeneratePerformanceReview();
    }
}
