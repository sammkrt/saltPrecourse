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
            set { this.birthYear = BirthYear; }
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

        public int GetAge(int currentYear)
        {
            return currentYear - birthYear;
        }

        public string GetPrintString()
        {
            return @$"{this.Name} 
            {this.Address!.Street} {this.Address.StreetNo} // (!) isaretini null hatasi firlatmasin diye koydum. Unlem koyunca nullForgiven islevi calisti. Null olursa da yok saydik.
            {this.Address.City}";
        }

        public Address? Address { get; set; }
    
    }

}

