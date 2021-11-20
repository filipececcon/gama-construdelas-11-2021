using System;
using Aplicativo.Automotores;

namespace Aplicativo
{
    class Caminhao : Automovel
    {
        public Caminhao(string marca, double potencia, string nome, double litros)
            : base(marca, potencia, nome, litros, ECombustivel.Diesel)
        {
           
        }

        public override void Abastecer(ECombustivel combustivel, double litros)
        {
            if(combustivel != ECombustivel.Diesel)
            {
                Console.WriteLine("Combustivel não permitido");
                return;
            }

            if (litros > CapacidadeLitros)
            {
                Console.WriteLine($"Capacidade máxima {CapacidadeLitros} litros excedida");
                return;
            }

            Console.WriteLine("Abastecendo caminhão");
            Tanque += litros;
        }
    }
}
