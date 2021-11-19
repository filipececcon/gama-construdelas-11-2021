using System;

namespace Aplicativo
{
    abstract class Automovel
    {
        public string Marca { get; set; }
        public double PotenciaMotor { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public double Tanque { get; set; }
        public double CapacidadeLitros { get; set; }

        public string MostraDados()
        {
            return $"Marca: {Marca}, Potencia: {PotenciaMotor}, Nome: {Nome}, Tanque: {Tanque}, Máximo(lts): {CapacidadeLitros}";
        }


        //metodos abstratos somente são possiveis em classes abstratas
        //quando fazemos um metodo abstrato todos os filhos da classe base são forçado a implementar
        public abstract void Abastecer(string combustivel, double litros);
        //{
        //    Console.WriteLine($"Abastecendo com {combustivel}, litros: {litros}");
        //}
    }
}
