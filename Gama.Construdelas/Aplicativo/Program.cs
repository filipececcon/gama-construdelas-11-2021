using System;
using System.Collections.Generic;

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

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
        
    }
}