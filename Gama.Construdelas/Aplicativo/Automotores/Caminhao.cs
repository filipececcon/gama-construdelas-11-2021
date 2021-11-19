using System;

namespace Aplicativo
{
    class Caminhao : Automovel
    {
        public Caminhao(string marca, double potencia, string nome, double maximo)
        {
            Marca = marca;
            PotenciaMotor = potencia;
            Nome = nome;
            CapacidadeLitros = maximo;
        }

        public override void Abastecer(string combustivel, double litros)
        {
            if(combustivel != "diesel")
            {
                Console.WriteLine("Combustivel não permitido");
            }
            else if (litros > CapacidadeLitros)
            {
                Console.WriteLine($"Capacidade máxima {CapacidadeLitros} litros excedida");
            }
            else
            {
                Console.WriteLine("Abastecendo caminhão");
                Tanque += litros;
            }
        }
    }
}
