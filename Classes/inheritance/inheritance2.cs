using System;
using System.Collections.ObjectModel;

namespace MeuCodigo
{
     class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("animal sound");
        }
    }

    class Test{
        public string color = "red";
    }
    class Pig : Animal
    {
         public override void animalSound()
        {

        }
    }
}
   