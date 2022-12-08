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

        // Unlem isareti ekledim. nullForgiven calistirdim boylece dereferance null hatasi almiyorum.
        public new string GetPrintString()
        {
            return @$"{this.Name} ({this.EmployeeId})
            {this.Address!.Street} {this.Address.StreetNo} 
            {this.Address.City}";
        }
    } 
}