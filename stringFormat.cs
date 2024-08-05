namespace StudyProject
{
    public static class StringFormat
    {
        public static void DemonstrateSrtingFormat()
        {
              Console.WriteLine("digite o seu nome");

                string? name =  Console.ReadLine();
                Console.WriteLine($"seu nome possui {name.Length} digitos");

                Console.WriteLine($"esse eh o seu nome em caixa alta \"{name.ToUpper()}\"");
                Console.WriteLine($"esse eh o seu nome em caixa baixa \"{name.ToLower()}\"");
        }
    }
}
