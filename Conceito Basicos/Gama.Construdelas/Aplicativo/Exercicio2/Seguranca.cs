using System;
namespace Aplicativo.Exercicio2
{
    public class Seguranca : Funcionario, IPorteiro, IVigilante, IObservadorDeCameras
    {
        public void ObservarCameras()
        {
            throw new NotImplementedException();
        }

        public void RegistrarEntrada()
        {
            Console.WriteLine("Entrada registrada");
        }

        public void RegistrarVisitante(string nome)
        {
            Console.WriteLine($"Visitante {nome} registrado pela segurança");
        }

        public void Vigiar()
        {
            Console.WriteLine("Vigiando cameras");
        }
    }
}
