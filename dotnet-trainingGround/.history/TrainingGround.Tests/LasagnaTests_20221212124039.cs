using TrainingGround;

namespace TrainingGroundTests
{
    public class LasagnaTests
    {
        [Fact]
        public void LasagnaTest()
        {
            Lasagna myObj = new Lasagna();
            Console.WriteLine(myObj.ExpectedMinutesInOven());
            Console.WriteLine(myObj.PreparationTimeInMinutes(3));
            Console.WriteLine(myObj.RemainingMinutesInOven(10));
            Console.WriteLine(myObj.ElapsedTimeInMinutes(3,20));

        }
    }
}