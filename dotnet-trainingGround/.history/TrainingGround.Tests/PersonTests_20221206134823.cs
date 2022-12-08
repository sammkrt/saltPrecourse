namespace TrainingGround.Tests
{
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

        [Theory]
        [InlineData(1992,2022,30)]
        [InlineData(2022,2022,0)]
        [InlineData(1982,2022,40)]
        [InlineData(1972,2022,50)]
        [InlineData(1962,2022,60)]
        public void calculating_ages(int value1, int value2, int expected)
        {
            var result = calculator.GetAge(value1,value2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void an_employee_is_a_person()
        {
            // act
            var emp = new Employee();
            emp.LengthInMeters = 1.95;

            // assert
            Assert.IsType(typeof(Employee), emp);
            Assert.Equal(1.95, emp.LengthInMeters);
        }

        [Fact]
        public void an_employee_has_an_employee_id()
        {
            //act 
            var emp = new Employee("Marcus", "234-BDAS");

            // assert
            Assert.IsType(typeof(Employee), emp);
            Assert.Equal("Marcus", emp.Name);
            Assert.Equal("234-BDAS", emp.EmployeeId);
        }
        
        [Fact]
        public void a_person_has_an_adress()
        {
            // arrange
            var p = new Person("Marcus");

            // act
            p.Address = new Address();
            p.Address.Street = "A street";
            p.Address.StreetNo = 23;
            p.Address.City = "Stockholm";

            // assert 
            Assert.NotNull(p.Address);
            Assert.IsType(typeof(Address), p.Address);
            Assert.Equal("A Street", p.Address.Street);
            Assert.Equal(23, p.Address.StreetNo);
            Assert.Equal("Stockholm", p.Address.City);
        }

   
   
   
    }


}
