namespace TrainingGround
{
    public class Employee : Person , IPrintable
    {
        public string? EmployeeId { get; set; }
        public List <Address> Addresses { get; set; }

        public Employee()
        {
            this.Addresses = new List<Address>();
        }

        public Employee(string name, string employeeId) : base(name)
        {
            this.Name = name;
            this.EmployeeId = employeeId;
            this.Addresses = new List<Address>();
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