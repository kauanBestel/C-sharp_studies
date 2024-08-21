using System;

namespace HelloWorld
{
    class Car //forma atualizada do arquivo OOP 3
    {
        public string model;
        public string color;
        public int year;
        public int id;

        public Car(string carModel, string carColor, int carYear, int carId)
        {
            model = carModel;   
            color = carColor;
            year = carYear;
            id = carId;
        }
    }
    class Programa1
    {
        static void Main(string[] args)
        {

            Car Ford = new Car("Mustang", "preto", 1995, 0001);
            Car Chevrollet = new Car("onix", "preto", 2015, 0002);
        }

    }
}