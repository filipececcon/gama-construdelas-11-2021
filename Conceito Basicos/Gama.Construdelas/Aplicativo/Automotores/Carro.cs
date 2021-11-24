using System;
using System.Linq;
using Aplicativo.Automotores;

namespace Aplicativo
{
    class Carro : Automovel
    {
        public Carro(string marca, double potencia, string nome, double maximo, ECombustivel combustivel)
            : base(marca, potencia, nome, maximo, combustivel, 4)
        {
            

        }

        public override void Abastecer(ECombustivel combutivelDaBomba, double litros)
        {

            if (Combustivel == ECombustivel.Flex
                && combutivelDaBomba != ECombustivel.Gasolina
                && combutivelDaBomba != ECombustivel.Alcool)
            {
                Console.WriteLine("Carro flex porém o combustivel não é permitido");
                return;
            }

            if (combutivelDaBomba != Combustivel)
            {
                Console.WriteLine("Combustivel não permitido");
                return;
            }

            if (litros > CapacidadeLitros)
            {
                Console.WriteLine($"Capacidade máxima {CapacidadeLitros} litros excedida");
                return;
            }

            Console.WriteLine("Abastecendo carro...");
            Tanque += litros;

            
        }
    }
}
