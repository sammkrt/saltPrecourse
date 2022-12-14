namespace TrainingGround.Tests
{
    public class TypesTest
    {
        [Fact]

        public void reference_types_can_be_changed_via_reference()
        {
        // arrange
        Person a = new Person("Person A");
        a.LengthInMeters = 1.95;
        Person b = a;

        // act
        b.LengthInMeters = 1.96;

        // assert
        Assert.Equal(1.96, b.LengthInMeters);
        Assert.Equal(1.96, a.LengthInMeters);
        }

        [Fact]
        public void value_types_cannot_be_changed_via_reference()
        {
            // arrange
            double aLengthInMeters = 1.95;
            double bLengthInMeters = aLengthInMeters;

            // act
            bLengthInMeters = 1.96;

            // assert
            Assert.Equal(1.96, bLengthInMeters);
            Assert.Equal(1.95, aLengthInMeters);
        }

        [Fact]
        public void getting_age_from_person()
        {
        Person p = new Person();
        // act
        var age = p.GetAge(1972,2022);
        
        // assert
        Assert.Equal(50,age);
        Assert.IsType(typeof(Person), p);
        Assert.IsType(typeof(int), age);

        }
    }
}