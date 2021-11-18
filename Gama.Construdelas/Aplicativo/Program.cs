using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var happyFeet = new Pinguim();

            happyFeet.Kilos = 50;


            //var animal = new Animal();
           
            
        }
    }

    //uma classe abstrata significa dizer que a mesma não pode ser instanciada
    abstract class Animal
    {
        public double Kilos { get; set; }

    }

    class Ave : Animal
    {

    }

    class Pinguim : Ave
    {

    }
}
