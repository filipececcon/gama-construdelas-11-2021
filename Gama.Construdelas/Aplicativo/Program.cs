using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            //o tipo fila não é inicializado com nenhu valor pois sua estrutura é baseado na ordem de entrada
            // conhecido com FIFO -> first in, first out (primeiro que entra é o primeiro que sai)
            var nomes = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"[{i}] Insira um novo nome:");

                var novoNome = Console.ReadLine();

                nomes.Enqueue(novoNome); //enqueue => serve para enfileirar um objeto ou tipo primitivo

                Console.WriteLine("nomes: "+ String.Join(", ", nomes));
            }

            Console.WriteLine($"Quantos nome vc quer desenfileirar ? [ maximo {nomes.Count}]");

            var quantidade = Convert.ToInt32(Console.ReadLine());

            //ao se lançar novas exceçoes, é quando queremos "quebrar" a execuçao do código 
            if (quantidade > nomes.Count) throw new Exception("Quantidade maior que o máximo");


            for (int i = 0; i < quantidade; i++)
            {

                Console.WriteLine($"[{i}] Desenfileirando um nome:");

                nomes.Dequeue(); // dequeue => serve para desenfileirar posiçoes

                Console.WriteLine("nomes: " + String.Join(", ", nomes));

            }



        }
    }
}