public class PersonTests
{
    private Person calculator;
    
    public PersonTests()
    {
        calculator = new Person();
    }
    
    [Fact]
    public void create_person_using_parameterless_constructor()
    {
        //act
        var p = new Person("Rase");

        // assert
        Assert.NotNull(p);
    }
    
    [Fact]
    public void create_person_using_constructor_with_name()
    {
        // act
        var p = new Person("Samet");
    
        // assert
        Assert.NotNull(p);
        Assert.Equal("Samet", p.Name);
    }

    [Fact]
    public void a_person_born_1972_is_50_2022()
    { 
        // act 
        var age = calculator.GetAge(1972,2022);

        // assert
        Assert.Equal(50, age);

    }

    [Fact]
    public void a_person_born_1982_is_40_2022()
    {

        // act
        var age = calculator.GetAge(1982,2022);

        // assert
        Assert.Equal(40, age);

    }

    [Fact]
    public void a_person_born_1992_is_30_2022()
    {
        // act
        var age = calculator.GetAge(1992,2022);

        // assert
        Assert.Equal(30, age);
    }

    [Fact]
    public void a_person_born_2022_is_0_2022()
    {
        // act
        var age = calculator.GetAge(2022,2022);

        // assert
        Assert.Equal(0, age);
    }

    [Theory]
    [InlineData(1992,2022,30)]
    [InlineData(2022,2022,0)]
    [InlineData(1982,2022,40)]
    [InlineData(1972,2022,50)]
    public void calculating_ages(int value1, int value2, int expected)
    {
        var result = calculator.GetAge(value1,value2);

        Assert.Equal(expected, result);
    }


}