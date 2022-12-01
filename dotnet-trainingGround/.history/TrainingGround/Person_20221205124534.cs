public class Person
{
    public Person()
    {

    }

    public Person(string name)
    {
        this.Name = name;
    }
    
    private string name;
    public string Name {get; private set;}
    public int BirthYear;
    public double LengthInMeters;
  


}

