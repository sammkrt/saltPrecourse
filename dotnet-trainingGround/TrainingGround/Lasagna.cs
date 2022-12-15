namespace TrainingGround
{
    public class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }
    
        public int RemainingMinutesInOven(int Min)
        {
            int result = 40 - Min;
            return result;
        }

        public int PreparationTimeInMinutes(int layer)
        {
            return layer * 2;
        }

        public int ElapsedTimeInMinutes(int layer, int Min)
        {
            int result = layer * 2 + Min;
            return result;
        }

    }
}