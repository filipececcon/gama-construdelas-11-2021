using System;
using System.Collections.Generic;
using System.Linq;
using Aplicativo.Exercicios;

namespace Aplicativo.Colecoes
{
    public class ListasEFiltros
    {
        public static void Rodar()
        {
            //List<TIPO>, IEnumerable<TIPO>, IQueryable<TIPO>

            #region Trabalhando com listas de textos

            var nomes = new List<string>() {
                "luiza",
                "matheus",
                "azdrubal",
                "eulalia",
                "odete",
                "gertrudes",
            };

            var nomesFiltrados = nomes.Where(nome => nome.Contains("a"));

            Console.WriteLine(String.Join(", ", nomesFiltrados));

            #endregion


            #region Trabalhando com listas numericas


            var salarios = new List<int>() { 1000, 6000, 1500, 2500, 3500, 700, 1200 };

            var salariosFiltrados = salarios.Where(salario => salario > 3000);

            var soma = salarios.Sum();

            var media = salarios.Average();

            Console.WriteLine(soma);

            Console.WriteLine(media);

            Console.WriteLine(String.Join(", ", salariosFiltrados));

            #endregion

            #region Trabalhando com listas de objetos complexos

            var funcionarios = new List<Funcionario>() {

                new Funcionario("jose", 5000),
                new Funcionario("joao", 3000),
                new Funcionario("maria", 10000),
                new Funcionario("odete", 8000),
                new Funcionario("genesio", 2000),
            };


            var funcionariosFiltrados = funcionarios
                //.Where(f => f.Nome.Contains("a"))
                .Where(f => f.Salario < 5000 && f.Nome.Contains("e"))
                //.Where(f => f.Nome.Contains("a"))
                .Select(f => $"{f.Nome} salario: {f.Salario} ");


            var mediaSalarial = funcionarios.Select(f => f.Salario).Average();

            Console.WriteLine(mediaSalarial);

            Console.WriteLine(String.Join(", ", funcionariosFiltrados));
            #endregion
        }
    }
}
