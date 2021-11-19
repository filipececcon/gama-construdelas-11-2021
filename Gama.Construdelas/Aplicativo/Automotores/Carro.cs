using System;

namespace Aplicativo
{
    class Carro : Automovel
    {
        public Carro(string marca, double potencia, string nome, double maximo)
        {
            Marca = marca;
            PotenciaMotor = potencia;
            Nome = nome;
            CapacidadeLitros = maximo;

        }

        public override void Abastecer(string combustivel, double litros)
        {
            if(combustivel != "gasolina" && combustivel != "alcool" && combustivel != "gnv")
            {
                Console.WriteLine("Combustivel não permitido");
            }

            else if(litros > CapacidadeLitros)
            {
                Console.WriteLine($"Capacidade máxima {CapacidadeLitros} litros excedida");
            }
            else
            {
                Console.WriteLine("Abastecendo carro...");
                Tanque += litros;
            }
        }
    }
}
