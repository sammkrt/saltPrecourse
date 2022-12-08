namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    private  AgeCalculator _calculator;
    public AgeCalculatorTests()
    {
       _calculator = new AgeCalculator();
    }
    
    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {
        // act
        var age = _calculator.GetAge(1972, 2022);

        // assert
        Assert.Equal(50, age);      
    }

    [Fact]

    public void someone_born_2022_is_0_in_2022()
    {
        // act
        var age = _calculator.GetAge(2022,2022);

        // assert
        Assert.Equal(0,age);
    }

    [Fact]

    public void someone_born_1955_is_67_in_2022()
    {
        //act
        var age = _calculator.GetAge(1955,2022);

        //assert
        Assert.Equal(67,age);
    }

    [Fact]

    public void someone_born_1945_is_77_in_2022()
    {
        // act
        var age = _calculator.GetAge(1945,2022);

        // assert
        Assert.Equal(77, age);
    }

    [Fact]
    public void return_under_18_for_kid()
    {
        // act
        var span = AgeCalculator.GetAgeSpan(AgeCalculator.AgeCategory.Kid);

        // assert
        Assert.Equal("Under 18 years", span);
    }

}

