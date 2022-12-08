namespace TrainingGround
{

    public class Person : IPrintable
    {
        public Person()
        {

        }

        public Person(string Name)
        {
            this.name = Name;
        }

        private string? name;
        public string? Name 
        {
            get { return name; }
            set{ this.name = value;}
        }
        private int birthYear;
        public int BirthYear
        {
            get { return birthYear; }
            private set { this.birthYear = BirthYear; }
        }
        public double LengthInMeters;

        public Person(int BirthYear)
        {
            this.birthYear = BirthYear;
        }
        
        public int GetAge(int BirthYear , int currentYear)
        {
            this.birthYear = BirthYear;
            return currentYear - BirthYear;
        }

        public string GetPrintString()
        {
            return @$"{this.Name} 
            {this.Address.Street} {this.Address.StreetNo}
            {this.Address.City}";
        }

        public Address? Address { get; set; }
    
    }

}

