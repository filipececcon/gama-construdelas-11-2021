using System;
namespace Aplicativo.Automotores
{
    public class ExemploAutomoveis
    {
        public static void Rodar()
        {

            var carro = new Carro("VW", 3.0, "golf", 50, ECombustivel.Diesel);

            var caminhao = new Caminhao("Volvo", 10.5, "Scania", 120);

            caminhao.Abastecer(ECombustivel.Gasolina, 30);

            Console.WriteLine(carro.MostraDados());
        }
    }
}
