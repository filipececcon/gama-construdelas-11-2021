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
            var melancias = new RepositorioDeFrutas<Melancia>();

            var moranguetes = new RepositorioDeFrutas<Morango>();




            moranguetes.Add(new Morango());
            melancias.Add(new Melancia());

            var panelas = new RepositorioDeFrutas<Panela>();
            var p = new Panela();
            panelas.Add(p);

        }
    }
}
