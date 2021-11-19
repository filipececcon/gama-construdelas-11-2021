using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            var salarios = new Dictionary<string, int>();

            var acao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Informe a açao desejada:");
                Console.WriteLine("1 - Adicionar Funcionario");
                Console.WriteLine("2 - Exibir salario por nome");
                Console.WriteLine("3 - Exibir os dados");
                Console.WriteLine("4 - Encerrar");

                acao = Convert.ToInt32(Console.ReadLine());

                switch (acao)
                {
                    case 1: AdicionarFuncionario(salarios); break;
                    case 2: ExibirSalarioPorNome(salarios); break;
                    case 3: ExibirDados(salarios); break;
                    default: break;
                }

                Console.ReadLine();

            } while (acao != 4);

            Console.WriteLine("-- Encerrado --");
        }

        static void AdicionarFuncionario(Dictionary<string,int> salarios)
        {
            Console.WriteLine("Digite o nome do funcionario:");

            var nome = Console.ReadLine();

            Console.WriteLine("Digite o salario do funcionario:");

            var salario = Convert.ToInt32(Console.ReadLine());

            salarios.Add(nome, salario);

            Console.WriteLine($"Adicionado o funcionario {nome} com o salario {salario}");
        }

        static void ExibirSalarioPorNome(Dictionary<string, int> salarios)
        {
            Console.WriteLine("Digite o nome do funcionario:");

            var nome = Console.ReadLine();

            Console.WriteLine($"O salario da pessoa {nome} é R${ salarios[nome] }");
        }

        static void ExibirDados(Dictionary<string, int> salarios)
        {
            Console.WriteLine("Disponivel: " + String.Join(",", salarios.Keys));

            Console.WriteLine("Media Salarial: " + salarios.Values.Sum() / salarios.Count);
        }
    }
}