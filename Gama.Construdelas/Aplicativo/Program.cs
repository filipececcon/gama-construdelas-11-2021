using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var carlos = new Pessoa() { Nome = "Carlos" };

            var carro1 = new Carro("VW", 1.5, "Gol");

            Console.WriteLine(carro1.MostraDados());
            
        }
    }


    class Pessoa
    {
        public string Nome { get; set; }
    }

    class Carro
    {
              
        public string Marca { get; set; }

        public double PotenciaMotor { get; set; }

        public string Nome { get; set; }


        //metodos construtores sempre tem o nome igual ao nome da classe
        public Carro(string marca, double potencia, string nome)
        {
            Marca = marca;
            PotenciaMotor = potencia;
            Nome = nome;
        }

        public string MostraDados()
        {
            return $"Marca: {Marca}, Potencia: {PotenciaMotor}, Nome: {Nome}";
        }

    }
}
