using System;

namespace HelloWorld
{
    class Program5
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
}