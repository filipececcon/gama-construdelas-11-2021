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

            salarios.Add("joao", 5000);

            salarios.Add("jose", 500);

            //salarios.Add("jose", 500); // a chave de um dicionario necessita ser unica para encontrar o registro desejado

            salarios.Add("maria", 20000);


            var salario = salarios["maria"];

            Console.WriteLine("o salario da maria é: R$" + salario);

            Console.Write(String.Join(",",salarios));

        }
    }
}