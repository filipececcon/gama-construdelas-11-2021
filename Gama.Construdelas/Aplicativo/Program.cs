using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            //o tipo Pilha não é inicializado com nenhum valor pois sua estrutura é baseado na ordem de entrada
            // conhecido com LIFO -> last in, first out (ultimo que entra é o primeiro que sai)
            var nomes = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"[{i}] Insira um novo nome:");

                var novoNome = Console.ReadLine();

                nomes.Push(novoNome); //push => serve para empilhar um objeto ou tipo primitivo

                Console.WriteLine("nomes: "+ String.Join(", ", nomes));
            }

            Console.WriteLine($"Quantos nome vc quer desempilhar? [ maximo {nomes.Count} ]");

            var quantidade = Convert.ToInt32(Console.ReadLine());

            //ao se lançar novas exceçoes, é quando queremos "quebrar" a execuçao do código 
            if (quantidade > nomes.Count) throw new Exception("Quantidade maior que o máximo");


            for (int i = 0; i < quantidade; i++)
            {

                Console.WriteLine($"[{i}] Desenfileirando um nome:");

                nomes.Pop(); // pop => serve para desempilhar posiçoes

                Console.WriteLine("nomes: " + String.Join(", ", nomes));

            }



        }
    }
}