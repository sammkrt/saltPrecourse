public class PersonTests
{
    
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

}