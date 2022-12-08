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
    
    
    }
}