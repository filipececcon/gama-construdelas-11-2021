using System;
using Aplicativo.Automotores;

namespace Aplicativo
{
    public abstract class Automovel
    {
        public string Marca { get; set; }
        public double PotenciaMotor { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public double Tanque { get; set; }
        public double CapacidadeLitros { get; set; }
        public ECombustivel Combustivel { get; set; }
        public int QtdePneus { get; set; }

        public Automovel(string marca, double potencia, string nome, double maximo, ECombustivel combustivel, int qtdepenus)
        {
            Marca = marca;
            PotenciaMotor = potencia;
            Nome = nome;
            CapacidadeLitros = maximo;
            Combustivel = combustivel;
            QtdePneus = qtdepenus;
        }

        public string MostraDados()
        {
            return $"Marca: {Marca}, Potencia: {PotenciaMotor}, Nome: {Nome}, Tanque: {Tanque}, Máximo(lts): {CapacidadeLitros}";
        }


        //metodos abstratos somente são possiveis em classes abstratas
        //quando fazemos um metodo abstrato todos os filhos da classe base são forçado a implementar
        public abstract void Abastecer(ECombustivel combustivelDaBomba, double litros);
        //{
        //    Console.WriteLine($"Abastecendo com {combustivel}, litros: {litros}");
        //}
    }
}
