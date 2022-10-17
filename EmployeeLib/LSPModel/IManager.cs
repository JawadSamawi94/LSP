namespace EmployeeLib.LSPModel
{
    public interface IManager<T> where T: CEO
    {
        public CEO EmployeeManager { get; set; } 
        // Manager renamed to supervisor because a class can't have a memeber with the same name
        // class Manager { public Manager }  X

        public void AssignManager(T manager);
    }
}
