using System;

namespace Aplicativo
{
    class Pinguim : Ave
    {
        public Pinguim(double peso)
        {
            Console.WriteLine("Eu sou um pinguim");

            Kilos = peso;
        }

        public void Nadar()
        {
            Console.WriteLine("Eu sou um pinguim mergulhador dos sete mares");
        }

    }


}