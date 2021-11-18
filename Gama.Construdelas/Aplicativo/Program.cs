using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var salarios = new int[] { 100, 4500, 500, 600 };

            var total = 0;

            //for (int i = 0; i < salarios.Length; i++)
            //{
            //    total = total + salarios[i];
            //}

            //para cada elemento da colecao é repetido o codigo dentro do escopo
            foreach (var s in salarios)
            {
                total = total + s;
            }


            var media = total / salarios.Length;

            Console.WriteLine(media);
        }
    }
}