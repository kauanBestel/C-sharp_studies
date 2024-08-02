namespace StudyProject
{
    public static class InputVariables
    {
        public static void DemonstrateInputVariables()
        {
             Console.WriteLine("type your age");
             int age = Convert.ToInt32(Console.ReadLine());
 
             Console.WriteLine("type your name");
             string? name = Console.ReadLine();

             Console.WriteLine($"Your name is {name} and you have {age} years");
        }
    }
}
