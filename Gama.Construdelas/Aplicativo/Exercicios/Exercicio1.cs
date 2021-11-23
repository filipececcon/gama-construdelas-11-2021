using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicativo.Exercicios
{
    /*
     
     Fazer uma aplicação do tipo Console com as especificações:

    - trabalhar com uma coleção do tipo Dictionary

    - o dicionário deve ter os tipos chave como inteiro e o valor o tipo Funcionário 
    (criar classe funcionário)

    - funcionario deve conter : nome(string) , salario(decimal) 

    - faça um método para aplicar um aumento de 10% do seu salário quando informado o nome

    Dica - pesquisar no google metodos de Lista para consulta
     
     */


    public class Exercicio1
    {
        public static void Rodar()
        {
            var funcionarios = new Dictionary<int, FuncionarioPosto>();

            funcionarios.Add(1, new FuncionarioPosto("joao", 5000));
            funcionarios.Add(2, new FuncionarioPosto("maria", 500));
            funcionarios.Add(3, new FuncionarioPosto("jose", 4000));
            funcionarios.Add(4, new FuncionarioPosto("abraao", 15000));
            funcionarios.Add(5, new FuncionarioPosto("noe", 8000));

            Console.WriteLine("Informe o nome do funcionario:");

            var nome = Console.ReadLine();

            AumentarSalario(funcionarios, nome);

            //usando linq para consultas e filtros
            Console.WriteLine(String.Join(",", funcionarios.Values.Select(x => x.Salario)));

            //usando linq para consultas e filtros
            Console.WriteLine($"Media salarial: { funcionarios.Values.Select(f => f.Salario).Average() }");
        }

        static void AumentarSalario(Dictionary<int, FuncionarioPosto> funcionarios, string nome)
        {
            //usando Linq para consultas
            var f1 = funcionarios.Values.Single(f => f.Nome == nome);

            f1.Salario = f1.Salario + (f1.Salario * 0.1M);

            //modo simples sem Linq
            //foreach (var f in funcionarios.Values)
            //{
            //    if(f.Nome == nome)
            //    {
            //        f.Salario = f.Salario + (f.Salario * 0.1M);

            //        Console.WriteLine($"o novo salario do funcionario {f.Nome} é de R${f.Salario}");
            //    }
            //}
        }
    }
}

