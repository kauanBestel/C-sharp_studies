namespace StudyProject
{
    public static class Variables
    {
        public static void DemonstrateVariables()
        {
             int num1 = 21;
             float num2 = 10.10f;
             const char A = 'a';
             string text = "hello";
             bool vscode = false;
             //para calculos, double é mais preciso que float

                Console.WriteLine(Convert.ToDouble(num1));

                Console.WriteLine(text+ "stranger! I'm "+num1+" years old" );
                text = "coding";
                Console.WriteLine($"i enjoy {text} and the number {num2} is {A} double!, i`m currently using visual studio, if i s{A}id i prefer it, it would be {vscode}");
                
                string final = string.Concat(A, text);

                Console.WriteLine(text[0]);
                Console.WriteLine(text.IndexOf("g"));
        }
    }
}
