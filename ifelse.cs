namespace StudyProject
{
    public static class Ifelse
    {
        public static void DemonstrateIfElse()
        {
                        
             Console.WriteLine("digite a sua idade");
            int idade = Convert.ToInt16(Console.ReadLine());
            int idadeVotar = 16;

            if (idade >= idadeVotar)
            {
                Console.WriteLine("pode votar");
            }
            else
            {
                Console.WriteLine("nao pode votar");
            }
        }
    }
}
