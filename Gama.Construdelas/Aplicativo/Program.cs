using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var happyFeet = new Pinguim();

           

            //Console.WriteLine();


            
           
            
        }
    }

    
    abstract class Animal
    {
        private double Kilos { get; set; }

        public Animal()
        {
            Kilos = 50;
            Console.WriteLine(Kilos);
        }

    }

    class Ave : Animal
    {
        public Ave()
        {
            Console.WriteLine("Eu sou uma ave");
        }
    }

    class Pinguim : Ave
    {
        public Pinguim()
        {
            Console.WriteLine("Eu sou um pinguim");
        }

    }
}
