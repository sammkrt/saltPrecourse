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
        [InlineData(AgeCalculator.AgeCategory.Adult)]

        public void defining_ages()
        {
            var result = AgeCalculator.GetAgeSpan(AgeCalculator.AgeCategory category);
            Assert.Equal(expected,result);
        }
    

    }
}