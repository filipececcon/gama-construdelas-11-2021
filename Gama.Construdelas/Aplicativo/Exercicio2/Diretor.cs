using System;
namespace Aplicativo.Exercicio2
{
    public class Diretor : Funcionario, IAdministrativo
    {
        public void AumentarSalario(Funcionario funcionario, decimal valor)
        {
            funcionario.Salario += valor;

            Console.WriteLine($"O salario do {funcionario.Nome } foi aumentado em R${valor} passando a {funcionario.Salario}");
        }
    }
}
