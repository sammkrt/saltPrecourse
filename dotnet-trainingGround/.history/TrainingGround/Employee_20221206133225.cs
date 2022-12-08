namespace TrainingGround
{
    public class Employee : Person
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
 
    } 
}