using System;

namespace Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {

            var happyFeet = new Pinguim(50);

            var surfista = new Pinguim(20);

            var simba = new Leao(300);


            happyFeet.Nadar();

            simba.Rugir();

            MostrarPeso(happyFeet);

            MostrarPeso(surfista);

            MostrarPeso(simba);

        }


        static void MostrarPeso(Animal animal)
        {
            Console.WriteLine("o peso do animal é: "+ animal.Kilos);
        }


        /*
         
         os 4 pilares da orientaçao a objetos:

        Herança : quando herdamos de uma classe obtemos todas as propriedades e metodos da classe base
        Encapsulamento: quando alteramos os modificadores de acesso para retrição ou visibilide de um metodos ou propriedade de uma class
        Polimorfismo: Quando passamos um paramentro de um tipo especifico que atende qualquer qualquer tipo que herde do mesmo ex: Animal serve para Pinguim e Leao
        Abstração: quando separamos metodos e proprieades que dizem respeito para um tipo especifico. ex: Pinguim consegue nadar e leao consegue Rugir
         
         
         */


    }

    
    abstract class Animal
    {
        public double Kilos { get; protected set; }
    }

    class Ave : Animal
    {
        public Ave() 
        {
            Console.WriteLine("Eu sou uma ave");
        }
    }

    class Felino : Animal
    {
        public Felino()
        {
            Console.WriteLine("eu sou um felino");
        }
    }

    class Pinguim : Ave
    {
        public Pinguim(double peso) 
        {
            Console.WriteLine("Eu sou um pinguim");

            Kilos = peso;
        }

        public void Nadar()
        {
            Console.WriteLine("Eu sou um pinguim mergulhador dos sete mares");
        }

    }

    class Leao : Felino
    {
        public Leao(double peso)
        {
            Console.WriteLine("eu sou um leão");

            Kilos = peso;
        }

        public void Rugir()
        {
            Console.WriteLine("Rugindoooooo....woooow");
        }
    }


}