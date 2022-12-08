namespace TrainingGround.Tests
{
    public class LinqTests
    {
        [Fact]
        public void loop_to_filter_numbers()
        {
            // arrange
            var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16 };

            // act
            foreach (int num in numbers)
            {
                if (num > 15)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}