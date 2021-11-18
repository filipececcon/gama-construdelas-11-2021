using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var nomes = new List<string>() { "joao", "maria", "jose" };

            Console.WriteLine("Insira um novo nome:");

            var novoNome = Console.ReadLine();

            nomes.Add(novoNome);

            Console.WriteLine(String.Join(", ", nomes));



            Console.WriteLine("Remova um nome:");

            var nomeRemovido = Console.ReadLine();

            nomes.Remove(nomeRemovido);

            Console.WriteLine(String.Join(", ", nomes));
        }
    }
}