namespace HelloWorld
{
    class Program
    {
        static void MyMethod(string country = "brasil")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("sweden");
            MyMethod();
           
        }
    }
}