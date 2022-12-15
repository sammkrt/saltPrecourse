namespace TrainingGroundTests
{
using TrainingGround;

    public class CheckNumsTEst
    {
        [Fact]
        public void NumKarsilatir()
        {
            // Given
            MainClass myObj = new MainClass();

            // When
            var result = myObj.CheckNums(10,20);
            Console.WriteLine(myObj.CheckNums(5,5));
            // Then
            Assert.Equal(result,"true");
        }
    }

}