public class PersonTests
{
    [Fact]
    public void create_person_using_parameterless_constructor()
    {
        //act
        var p = new Person();

        // assert
        Assert.NotNull(p);
    }
}