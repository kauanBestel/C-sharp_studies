namespace StudyProject
{
    public static class DoWhile
    {
        public static void DemonstrateDoWhile()
        {
             int i = 0;
            while(i < 10)
            {
                 i = i + 1;
                Console.WriteLine(i);
            }
                Console.WriteLine("--------");

            do
            {
                i++;
                Console.WriteLine(i);
            }
            while(i < 20);

                Console.WriteLine("--------");

            for (int a = 0; a<=10; a = a+2)
            {
                Console.WriteLine(i);
            }

            //nested loop, onde sempre que o loop de dentro vai ser executado quando o de fora for executado
            // Outer loop
            for (int b = 1; b <= 2; ++b) 
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

             // Inner loop
              for (int j = 1; j <= 3; j++) 
              {
                   Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
              }
            }
        }
    }
}
