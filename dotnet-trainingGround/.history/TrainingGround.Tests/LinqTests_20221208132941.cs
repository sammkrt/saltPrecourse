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
           // Assert
           Assert.Equal(4, numberList.Count); 

        }
    }
}