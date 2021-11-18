using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
                      

            var carro1 = new Carro("VW", 1.5, "Gol");

            var caminhao1 = new Caminhao("Volvo", 5.5, "CT505");


            Console.WriteLine(caminhao1.MostraDados());


            //conceito DRY -> dont repeat yourself -> não se repita
            
        }
    }
}
