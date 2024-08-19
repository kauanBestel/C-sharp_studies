namespace StudyProject
{
    public static class Ifelse
    {
        public static void DemonstrateIfElse()
        {
                        
            
            Console.WriteLine("Digite as suas notas das 3 provas que você fez:");

            double nota1, nota2, nota3;

            Console.Write("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            double mediaFinal = (nota1 + nota2 + nota3) / 3;

            if (mediaFinal >= 5)
            {
                Console.WriteLine($" voce passou! sua media final e {mediaFinal}");
            }
            else if (mediaFinal > 4 && mediaFinal < 5)
            {
                Console.WriteLine($"voce reprovou mas foi por pouco!. sua media final e {mediaFinal}");

            }
            else
            {
                Console.WriteLine("voce reprovou mizeravelmentem melhre da proxima");
            }
        }
    }
}
