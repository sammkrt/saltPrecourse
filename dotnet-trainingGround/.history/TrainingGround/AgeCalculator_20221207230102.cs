namespace TrainingGround;
public class AgeCalculator 
{
    public int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person,int currentYear)
    {
        var age = person.GetAge(currentYear);
        
        if (age > 49 && age < 51)
        {
            return AgeCategory.Prime;
        }
        if (age <= 18)
        {
            return AgeCategory.Kid;
        }
        return AgeCategory.Adult;
        
    }        

    public enum AgeCategory
    {
        Kid,
        Adult,
        Prime
    }

}
