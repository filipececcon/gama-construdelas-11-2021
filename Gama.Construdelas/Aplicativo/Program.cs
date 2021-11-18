using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var salario1 = 100;
            var salario2 = 4500;
            var salario3 = 500;

            //var media = (salario1 + salario2 + salario3) / 3;


            var salarios = new int[] { 100, 4500, 500, 600 };

            var total = 0;

            for (int i = 0; i < salarios.Length; i++)
            {
                total = total + salarios[i];
            }

            var media = total / salarios.Length;

            Console.WriteLine(media);
        }
    }
}