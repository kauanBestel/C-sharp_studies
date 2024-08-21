using System;

namespace HelloWorld
{
    class Carro
    {
        //atributos de Car
        public string color = "red";
        public string color2 = "green";
        public string size = "3";
    }

    class Programa
    {
        static void Main(string[] args)
        {
        Carro carro1 = new Carro();
            Console.WriteLine(carro1.color);
            Console.WriteLine(carro1.color2);

        }
    }
}