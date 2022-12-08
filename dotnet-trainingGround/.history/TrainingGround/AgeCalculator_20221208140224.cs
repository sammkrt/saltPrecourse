﻿namespace TrainingGround;
public class AgeCalculator 
{
    public int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person,int currentYear)
    {
        var age = person.GetAge(currentYear);
        
        if (age == 50)
        {
            return AgeCategory.Prime;
        }
        if (age <= 18)
        {
            return AgeCategory.Kid;
        }
        return AgeCategory.Adult;
        
    }

    public static string GetAgeSpan(AgeCategory category)
    {
        switch (category)
        {
            case AgeCategory.Kid:
                return "Under 18 years";
            case AgeCategory.Adult:
                return "Above 18";
            case AgeCategory.Prime:
                return "Exactly 50 - and proud!";
            default:
                return "Unknown";
        }
    }
        
    
    public enum AgeCategory
    {
        Kid,
        Adult,
        Prime 
    }

}
