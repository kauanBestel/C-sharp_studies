namespace StudyProject
{
    public static class Arrays
    {
        public static void DemonstrateArrays()
        {
                        
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //cars[2] = "chevrolet";
            //Console.WriteLine(cars.Length);

            //string[] car = new string[4];

            //string[] cars = new string[4] { "volvo", "ford", "porsche", "mazda" };

            //string[] fruits = new string[] { "apple", "grape", "lemon", "orange", "banana" };

            //string[] test = { "isso", "eh", "um", "teste" };

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine($"Index {i}: {cars[i]}");
            //}

            string[] cars = { "volvo", "mazda", "mercedes" };
            foreach( string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
