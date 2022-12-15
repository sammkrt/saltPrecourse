namespace TrainingGround.Tests
{
    public class LinqTests
    {
        [Fact]
        public void loop_to_filter_numbers()
        {
            // arrange
            var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16 };
            var numberList = new List<int> {};
            // act
            foreach (int num in numbers)
            {
                if (num > 15)
                {
                    numberList.Add(num);
                }
            }
            foreach (int num2 in numberList)
            {
                Console.Write(num2 + "-");   
            }
            Console.WriteLine();
           // Assert
           Assert.Equal(4, numberList.Count); 
        }

        [Fact]
        public void linq_to_filter_numbers()
        {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = numbers.FindAll(number => number > 15);

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
        }
    
        [Fact]
        public void linq_to_find_first()
        {
            // arrange
            var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

            // act
            var firstNumberLargerThan15 = numbers.Find(number => number > 15);

            // assert
            Assert.Equal(53, firstNumberLargerThan15);
        }

        [Fact]
        public void linq_to_check_if_any_matches()
        {
            // arrange
            var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };
            
            //act
            var anyOver100 = numbers.Any(number => number > 100);

            // assert
            Assert.False(anyOver100);
        }

        [Fact]
        public void linq_to_check_all_numbers_positive()
        {
            // arrange
            var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

            // act
            var allPositive = numbers.All(number => number > 0);

            // assert
            Assert.True(allPositive);
        }

        [Fact]
        public void filter_people_by_age()
        {
            // arrange
            var people = new List<Person> {
                new Person("Aaaron"),
                new Person("Bea"),
                new Person("Ceasar"),
                new Person("Dave")
            };
            
            // act - Unlem kullandim cunku yine dereference hatasi aliyordum
            var allWithLongName = people
            .Where(p => p.Name!.Length > 4)
            .ToList();

            // assert
            Assert.Equal(2, allWithLongName.Count);
            Assert.Equal("Aaaron", allWithLongName[0].Name);
        
        }

        [Fact]
        public void filter_people_by_age_only_names()
        {
            // arrange
            var people = new List<Person> {
            new Person("Aaaron"),
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave")
            };            
        
            // act
            var allWithLongNames = people
            .Where (p => p.Name!.Length > 4)
            .Select(p => p.Name)
            .ToList();

            // assert
            Assert.Equal(2, allWithLongNames.Count);
            Assert.Equal("Aaaron", allWithLongNames[0]);
            Assert.Equal("Ceasar", allWithLongNames[1]);    
        }
    
        [Fact]
        public void filter_people_by_age_names_age()
        {
            //arrange
            var a = new Person("Aaaron");
            a.LengthInMeters = 1.96;
            var people = new List<Person> {
                a,
                new Person("Bea"),
                new Person("Ceasar"),
                new Person("Dave")
            };
        
            // act
            var namesAndAges = people
            .Where(p => p.Name!.Length > 4)
            .Select(p => new { Name = p.Name, Height = p.LengthInMeters })
            .ToList();

            // assert
            Assert.Equal(2, namesAndAges.Count);
            Assert.Equal("Aaaron", namesAndAges[0].Name);
            Assert.Equal(1.96, namesAndAges[0].Height); 
        }
    
        [Fact]
        public void filter_people_by_age_names_age_query_syntax()
        {
            // arrange
            var a = new Person("Aaaron");
            a.LengthInMeters = 1.96;
            var people = new List<Person> {
                a,
                new Person("Bea"),
                new Person("Ceasar"),
                new Person("Dave")
            };            
        
            // act
            var query =
                from p in people
                where p.Name!.Length > 4
                select new { Name = p.Name, Height = p.LengthInMeters };
                var namesAndAges = query.ToList();
                                
            // assert
            Assert.Equal(2, namesAndAges.Count);
            Assert.Equal("Aaaron", namesAndAges[0].Name);
            Assert.Equal(1.96, namesAndAges[0].Height); 
        }         
       
       
    
    }
}
