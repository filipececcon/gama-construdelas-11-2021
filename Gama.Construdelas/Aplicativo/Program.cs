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
        public double Kilos { get; set; }

    }

    class Ave : Animal
    {

    }

    class Pinguim : Ave
    {
        public Pinguim(double peso)
        {
            Kilos = peso;
        }

    }
}
