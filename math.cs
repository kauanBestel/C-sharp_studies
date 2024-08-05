namespace StudyProject
{
    public static class IMath
    {
        public static void DemonstrateMath()
        {
              int w = 5;
              int x = 10;
              float y = -4.7f;


                Console.WriteLine(Math.Max(w, x));  
                Console.WriteLine(Math.Min(w, x));
                Console.WriteLine(Math.Abs(y));
                Console.WriteLine(Math.Round(y));
                
        }

    }
}
