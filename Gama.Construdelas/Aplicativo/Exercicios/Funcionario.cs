using System;
using Aplicativo.Automotores;

namespace Aplicativo.Exercicios
{
    //interfaces só podem ser implementadas, quando falamos de herança serve somente para classes
    //uma classe só pode herdar uma outra, e não mais de uma, porém implementaçao de interfaces são ilimitadas
    //interfaces não são instanciadas, somente classes não abstratas pode ser instanciadas (crira objetos)
    class Funcionario : IFrentista, IBorracheiro
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public void Abastecer(Automovel automovel, ECombustivel combustivelDaBomba, double litros)
        {
            automovel.Abastecer(combustivelDaBomba, litros);
        }

        public void CalibrarPneus(Automovel automovel)
        {
            Console.WriteLine($"Calibrando {automovel.QtdePneus} pneus");
        }

        public void TrocarRoda(Automovel automovel)
        {
            Console.WriteLine($"Trocando {automovel.QtdePneus} rodas");
        }
    }
}

