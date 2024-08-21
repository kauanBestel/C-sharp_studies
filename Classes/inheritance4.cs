using System;

namespace HelloWorld
{   
    //classe abstrata nao pode ser inicializada, apenas herdada
  abstract class Rock
    {
        public abstract void rockSound();
    }

    class Decoration : Rock
    {
        public override void rockSound()
        {
            Console.WriteLine("e pedra fala por acaso?");
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            Decoration perda = new Decoration();
            perda.rockSound();
        }
    }
}