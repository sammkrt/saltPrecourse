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
            Assert.Equal(17, category);
        }
    }
}