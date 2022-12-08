namespace TrainingGround;
public class AgeCalculator 
{
    public int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person,int currentYear)
    {
        return AgeCategory.Kid;
    }        

    public enum AgeCategory
    {
        Kid
    }

}
