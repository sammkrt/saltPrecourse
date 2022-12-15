namespace TrainingGround
{
    public class MainClass
    {
        
        public string CheckNums(int num1, int num2)
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
    /*
    public static void Main(string[] args)
    {
        
        var myObj = new MainClass();
        
        Console.WriteLine(myObj.CheckNums(10,20));
    }
    */
}
