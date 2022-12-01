public class Person
{
    public Person()
    {

    }
/*
    public Person(string name)
    {
        this.Name = name;
    }
  */
    private string name;
    public string Name 
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

    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }
    
    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }
}



