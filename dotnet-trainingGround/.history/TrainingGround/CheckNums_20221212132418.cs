namespace TrainingGround
{
    public class MainClass
    {
        public static string CheckNums(int num1, int num2)
        {
            if (num1 == num2)
            {
                return "-1";
            }
            else if (num1 > num2)
            {
                return "false";
            }
            else
            {
                return "true";
            }
        }

    }
}