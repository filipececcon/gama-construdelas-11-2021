using System;
namespace Aplicativo.Exercicio2
{
    public class Recepcionista : Funcionario, IRecepcao
    {
        public void RegistrarVisitante(string nome)
        {
            Console.WriteLine($"Visitante {nome} registrado pela recepcionista");
        }
    }
}
