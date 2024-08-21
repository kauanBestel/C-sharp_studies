using System;
using System.Net.NetworkInformation;

namespace HelloWorld
{   
    //classe interface eh totalmente abstrata e publica, e nao pode ter corpo  void animalSound(){corpo}
    //eh uma boa pratica inicial o nome dessas classes de interface com "I"
    //o c# nao suporta multiplas herancas, uma classe so pode herdar de um outra classe, mas com a interface isso se torna possivel.
  interface IAnimals
    {
        void animalSound();
        void run();
    }

   interface Iuseless
    {
        void uselessMethod();
    }

    class Cavalo : IAnimals, Iuseless
    {
            //eu tenho que inicializar todos os metodos herdados do Ianimals

        public void uselessMethod()
        {
            Console.WriteLine("inutil");
        }
        public void animalSound()
        {
            Console.WriteLine("Som de cavalo");
        }
        public void run()
        {
            Console.WriteLine("o cavalo esta correndo");
        }
    }

    class Program4
    {
    static void Main(string[] args)
        {
            Cavalo cav1 = new Cavalo();
            cav1.animalSound();
        }

    }
}