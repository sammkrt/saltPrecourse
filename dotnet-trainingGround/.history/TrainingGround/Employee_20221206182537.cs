namespace TrainingGround
{
    public class Employee : Person , IPrintable
    {
        public string? EmployeeId { get; set; }
        public Employee(string name, string employeeId) : base(name)
        {
            this.Name = name;
            this.EmployeeId = employeeId;
        }
        public Employee()
        {

        }

        public string GetPrintstring()
        {
            throw new NotImplementedException();
        }
    } 
}