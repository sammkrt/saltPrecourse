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
            p.Address.Street = "A Street";
            p.Address.StreetNo = 23;
            p.Address.City = "Stockholm";

            // assert 
            Assert.NotNull(p.Address);
            Assert.IsType(typeof(Address), p.Address);
            Assert.Equal("A Street", p.Address.Street);
            Assert.Equal(23, p.Address.StreetNo);
            Assert.Equal("Stockholm", p.Address.City);
        }

        [Fact]
        public void an_employee_gets_a_nice_printed_address()
        {
            // arrange
            var emp = new Employee("Marcus", "234-BDAS");
            emp.Address = new Address();
            emp.Address.Street = "A Street";
            emp.Address.StreetNo = 23;
            emp.Address.City = "Stockholm";

            // act
            var printString = emp.GetPrintString();

            // assert
            Assert.Equal(@"Marcus (234-BDAS)
            A Street 23
            Stockholm", printString);
        }
   
        public void Print(IPrintable printable){
            var printString =printable.GetPrintString();
            Console.WriteLine(printString);
        }

        [Fact]

        public void can_print_printables()
        {
            // arrange
            var emp = new Employee("Ossian", "234-BDAS");
            emp.Address = new Address();
            emp.Address.Street = "B Street";
            emp.Address.StreetNo = 22;
            emp.Address.City = "Malmo";

            var p = new Person("Marcus");
            p.Address = new Address();
            p.Address.Street = "A Street";
            p.Address.StreetNo = 23;
            p.Address.City = "Stockholm";

            // act
            this.Print(p);
            this.Print(emp);

        }

        [Fact]
        public void showing_objeect_initializer()
        {
            // act
            var a = new Address();
            a.Street = "B street";
            a.StreetNo = 22;
            a.City = "Malmo";

            var b = new Address
            {
                Street = "B street",
                StreetNo = 22,
                City = "Malmo"
            };

            // assert
            Assert.Equal(a.Street, b.Street);
            Assert.Equal(a.StreetNo,b.StreetNo);
            Assert.Equal(a.City,b.City);

        }
    
        [Fact]
        public void an_employee_have_more_than_one_adress()
            {
                // arrange 
                var emp = new Employee("Marcus", "DBCSAS-1253");

                // act
                emp.Addresses.Add(new Address() { Street = "Work street", StreetNo = 2, City = "Stockholm" });
                emp.Addresses.Add(new Address() { Street = "Vacation Street", StreetNo = 2, City = "Honolulu" });

                // assert
                Assert.Equal(2,emp.Addresses.Count);
            }
        
    }


}
