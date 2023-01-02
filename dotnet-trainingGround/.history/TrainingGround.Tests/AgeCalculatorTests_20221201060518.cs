namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    private AgeCalculator _calculator;
    
    public AgeCalculatorTests()
    {
    _calculator = new AgeCalculator();
    }

    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {
        // arrange
        //var calculator = new AgeCalculator();

        // act
        var age = _calculator.GetAge(1972, 2022);

        // assert
        Assert.Equal(50, age);   
        
    }

    [Fact]

    public void someone_born_2022_is_0_in_2022()
    {
        // arrange 
        //var calculator = new AgeCalculator();

        // act
        var age = _calculator.GetAge(2022,2022);

        // assert
        Assert.Equal(0,age);
    }
}
