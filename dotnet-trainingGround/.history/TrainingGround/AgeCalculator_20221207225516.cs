namespace TrainingGround;
public class AgeCalculator 
{
    public int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person,int currentYear)
    {
        var isOlderThan18 = person.GetAge(currentYear) > 18;
        
        if (isOlderThan18)
        {
            return AgeCategory.Adult;
        }
        return AgeCategory.Kid;
        
    }        

    public enum AgeCategory
    {
        Kid,
        Adult
    }

}
