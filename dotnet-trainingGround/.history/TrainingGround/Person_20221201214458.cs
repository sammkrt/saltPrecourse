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
    public int BirthYear;
    public double LengthInMeters;

    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }
}



