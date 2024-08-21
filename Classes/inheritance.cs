using System;

namespace MeuCodigo
{
    class Vehicle
    //posso usar "sealed class vehicle" pra tornala não herdavel.
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.Write("tu tu!");
        }
    }
    class Car : Vehicle
    {
        public string model = "Mustang";
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine($"{myCar.brand} {myCar.model}");
        }
    }
}