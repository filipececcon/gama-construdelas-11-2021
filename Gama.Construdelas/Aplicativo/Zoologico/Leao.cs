using System;

namespace Aplicativo
{
    class Leao : Felino
    {
        public Leao(double peso)
        {
            Console.WriteLine("eu sou um leão");

            Kilos = peso;
        }

        public void Rugir()
        {
            Console.WriteLine("Rugindoooooo....woooow");
        }
    }


}