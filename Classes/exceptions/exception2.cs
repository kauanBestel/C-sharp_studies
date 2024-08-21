using System;

class Program
{
    static void checkage(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Access denied - must be at least 18");
        }
        else
        {
            Console.WriteLine("Access granted");
        }
    }

    static void Main(string[] args)
    {
        // Solicita que o usuário digite a idade
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        try
        {
            checkage(age); // Passa a idade para o método checkage
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }

        // `return` removido, pois não é necessário em um método `Main` do tipo `void`
    }
}
