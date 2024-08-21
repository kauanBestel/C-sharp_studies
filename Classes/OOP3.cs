using System;

namespace HelloWorld
{
   class Vehiculo
    {
        string? modelo;
        string? cor;
        int year;

         static void Main(string[] args)
        {
            Vehiculo Ford = new Vehiculo();
            Ford.modelo = "mustang";
            Ford.cor = "blue";
            Ford.year = 1969;
            void fullThrotlleFord()
            {
                Console.WriteLine("this Vehiculo is to old to acelerate like that");
            }


            Vehiculo Opel = new Vehiculo();
            Opel.modelo = "Astra";
            Opel.cor = "grey";
            Opel.year = 2005;

            Console.WriteLine(Ford.modelo);
            Console.WriteLine(Opel.modelo);
         }
    }
}