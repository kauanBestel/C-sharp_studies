namespace StudyProject
{
    public static class SortArrays
    {
        public static void DemonstrateSortArrays()
        {
            int[] cars = { 4, 1, 6, 3 };
            Array.Sort(cars);
            foreach (int i in cars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(cars.Sum());
        }
    }
}
