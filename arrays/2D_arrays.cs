namespace StudyProject
{
    public static class Arrays2D
    {
        public static void Demonstrate2DArrays()
        {
                        
            int[,] numbers = {
                 { 1, 4, 2 },
                 { 3, 6, 8 },
                 { 6, 3, 9 },
                 { 5, 7, 11},     
                 };


            //o 'i' vai servir de index que vai percorrer as linhas do array. como declaramos ele igual a 0, 
            //entao ele via comecar do 0, se referindo a primeira linha do array
            for (int i = 0; i < numbers.GetLength(0); i++)
            //o numbers.GetLenght(0) foi definido como 0 entao ele vai ler as linhas
            //caso fose 1, ele leria as colunas
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            
            }
        }
    }
}
