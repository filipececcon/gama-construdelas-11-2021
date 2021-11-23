using System;
using Aplicativo.Exercicios;

namespace Aplicativo.Automotores
{
    public class ExemploAutomoveis
    {
        public static void Rodar()
        {

            var carro = new Carro("VW", 3.0, "golf", 50, ECombustivel.Diesel);

            var caminhao = new Caminhao("Volvo", 10.5, "Scania", 120, 12);

            
            
            var frentista = new FuncionarioPosto("jose", 4000);

            frentista.Abastecer(carro, ECombustivel.Gasolina, 60);

            frentista.CalibrarPneus(caminhao);

            frentista.TrocarRoda(caminhao);

            Console.WriteLine(carro.MostraDados());
        }
    }
}
