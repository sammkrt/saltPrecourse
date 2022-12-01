public class PersonTests
{
    
    [Fact]
    public void create_person_using_parameterless_constructor()
    {
        //act
        Person p = new Person();

        // assert
        Assert.NotNull(p);
    }
    
    [Fact]
    public void create_person_using_constructor_with_name()
    {
        // act
        Person p = new Person();
        p.Name = "Samet";
        // assert
        Assert.NotNull(p);
        Assert.Equal("Samet", p.Name);
    }

    [Fact]
    public void a_person_born_1972_is_50_2022()
    {
        // arrange
        var p = new Person();
        p.BirthYear = 1972;

        // act 
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);

    }



}