namespace TrainingGround;
public class AgeCalculator 
{
    public int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person,int currentYear)
    {
        if (person.GetAge(currentYear) > 18)
        {
            return AgeCategory.Adult;
        }
        else
        {
            return AgeCategory.Kid;
        }
    }        

    public enum AgeCategory
    {
        Kid,
        Adult
    }

}
