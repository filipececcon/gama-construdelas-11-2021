using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var happyFeet = new Pinguim(50);

            happyFeet.Kilos = 30;

            Console.WriteLine(happyFeet.Kilos);

        }
    }

    
    abstract class Animal
    {
        public double Kilos { get; protected set; }
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
        public Pinguim(double peso) 
        {
            Console.WriteLine("Eu sou um pinguim");

            Kilos = peso;
        }

    }
}