namespace StudyProject
{
    public static class QuickIfelse
    {
        public static void DemonstrateQuickIfElse()
        {
            //Ternary Operator
            int time = Convert.ToUInt16(Console.ReadLine());
            string result = (time < 18) ? "good day" : "good evening";
            Console.WriteLine(result);

            
            
        }
    }
}
