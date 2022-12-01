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

}