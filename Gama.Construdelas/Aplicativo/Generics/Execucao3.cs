using System;
namespace Aplicativo.Generics
{
    public class Execucao3
    {
        public static void Rodar()
        {

            /*
             
             Quando trabalhamos com generics deixamos a implementaçao flexivel para podemos utilizarmos para qualquer tipo
             
             */
            var melancias = new Repositorio<Melancia>();

            var moranguetes = new Repositorio<Morango>();




            moranguetes.Add(new Morango());
            melancias.Add(new Melancia());
            moranguetes.Add(new Manga());




        }
    }
}
