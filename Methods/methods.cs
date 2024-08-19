namespace HelloWorld
{
    class Program
    {
         static int PlusMethodInt(int x, int y)
        {
            return x + y;
         }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y; 
        }


        static void Main(string[] args)
        {
            int num1 = PlusMethodInt(8, 5);
            double num2 = PlusMethodDouble(3.3, 1.4);
            Console.WriteLine("int:" + num1);
            Console.WriteLine(Math.Round(num2));
         }
    }
}