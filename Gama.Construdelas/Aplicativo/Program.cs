using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var salarios = new int[] { 100, 4500, 500, 600 };

            var total = 0;

            salarios[4] = 500; // arrays não sao dinamicos, nao podem ser adicionadas novas posiçoes em tempo de execuçao

            for (int i = 0; i < salarios.Length; i++)
            {
                total = total + salarios[i];
            }

            var media = total / salarios.Length;

            Console.WriteLine(media);
        }
    }
}