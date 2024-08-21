using System;

namespace HelloWorld
{
    class Dor
    {
        //um atributo de Dor
        string color = "red";

        static void Main(string[] args)
        {
            Dor dor1 = new Dor();
            Dor dor2 = new Dor();
            Console.WriteLine(dor1.color);
            Console.WriteLine(dor2.color);
        }
    }
}