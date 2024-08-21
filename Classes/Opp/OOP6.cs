using System;

namespace HelloWorld
{
    class Person
    {
        private string? name; //private field
        public string Name    //property
        {
            get { return name; }
            set { name = value;}
        }
        //{get ; set;}
    }
    
    class Program2
    {
        static void Main(string[] args)
        {
            Person pamela = new Person();
            pamela.Name = "pam";
            Console.WriteLine(pamela.Name);
        }
    }
    
}