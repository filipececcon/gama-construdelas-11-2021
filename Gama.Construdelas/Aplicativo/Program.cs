using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var carlos = new Pessoa() { Nome = "Carlos" };

            var carro1 = new Carro() { Marca = "GM", PotenciaMotor = 2.4, Nome = "Monza" };

            Console.WriteLine(carro1.MostraDados());
            
        }
    }


    class Pessoa
    {
        public string Nome { get; set; }
    }

    class Carro
    {

        //propriedades, são proprias para guardar estado(valores)
        public string Marca { get; set; }

        public double PotenciaMotor { get; set; }

        public string Nome { get; set; }


        //método, são para guardar comportamentos
        public string MostraDados()
        {
            return $"Marca: {Marca}, Potencia: {PotenciaMotor}, Nome: {Nome}";
        }

    }
}
