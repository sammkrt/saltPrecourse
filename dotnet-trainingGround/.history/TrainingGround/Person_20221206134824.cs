namespace TrainingGround
{

    public class Person
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

        public Address Address { get; set; }

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
    }

}

