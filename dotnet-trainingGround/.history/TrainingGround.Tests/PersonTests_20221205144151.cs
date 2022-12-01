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
        var age = calculator.GetAge(2022,1972);

        // assert
        Assert.Equal(50, age);

    }

    [Fact]
    public void a_person_born_1982_is_40_2022()
    {
        // arrange
        var p = new Person(1982);

        // act
        var age = p.GetAge(2022,1982);

        // assert
        Assert.Equal(40, age);

    }

    [Fact]
    public void a_person_born_1992_is_30_2022()
    {

    }

    [Fact]
    public void a_person_born_2022_is_0_2022()
    {

    }

}