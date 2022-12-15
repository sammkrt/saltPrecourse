namespace TrainingGroundTests
{
    public class ExceptionTests
    {
        [Fact]
        public void not_handling_an_exception()
        {
            // arrange
            var i = 1;

            // act
            var result = 14 / (i - 1);
        }
    }
}