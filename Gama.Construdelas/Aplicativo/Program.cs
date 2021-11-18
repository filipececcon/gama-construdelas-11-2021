using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var happyFeet = new Pinguim(50);

           

            //Console.WriteLine();


            
           
            
        }
    }

    
    abstract class Animal
    {
        private double Kilos { get; set; }

        public Animal(double peso)
        {
            Kilos = peso;
            Console.WriteLine(Kilos);
        }

    }

    class Ave : Animal
    {
        public Ave(double peso) : base(peso)
        {
            Console.WriteLine("Eu sou uma ave");
        }
    }

    class Pinguim : Ave
    {
        public Pinguim(double peso) : base(peso)
        {
            Console.WriteLine("Eu sou um pinguim");

            
        }

    }
}
