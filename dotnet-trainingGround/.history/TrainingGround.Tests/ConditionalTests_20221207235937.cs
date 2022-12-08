namespace TrainingGround.Tests
{
    public class ConditionalTest
    {
        [Fact]
        public void should_be_kid_when_younger_than_18()
        {
            //arrange
            var p = new Person(2005);

            // act
            var category = AgeCalculator.GetAgeCategory(p,2022);

            // assert
            Assert.Equal(AgeCalculator.AgeCategory.Kid, category);
        }
    
        [Fact]
        public void should_be_adult_when_older_than_18()
        {
            // arrange
            var p = new Person(2002);

            // act
            var category = AgeCalculator.GetAgeCategory(p,2022);

            // assert
            Assert.Equal(AgeCalculator.AgeCategory.Adult, category);
        }

        [Fact]
        public void when_50_then_prime_Age()
        {
            // arrange
            var p = new Person(1972);

            // act
            var category = AgeCalculator.GetAgeCategory(p,2022);

            // assert
            Assert.Equal(AgeCalculator.AgeCategory.Prime, category);
        }

    
        [Fact]
        public void return_under_18_for_kid()
        {
            // act
            var span = AgeCalculator.GetAgeSpan(AgeCalculator.AgeCategory.Adult);

            // assert
            Assert.Equal("Above 18", span);
        }

        [Theory]
        [InlineData(AgeCalculator.AgeCategory.Adult, "Above 18")]

        public void defining_ages(string value1, string expected)
        {
            var result = AgeCalculator.GetAgeSpan(AgeCalculator.AgeCategory.value1);
            Assert.Equal(expected,result);
        }
    
    
    }
}