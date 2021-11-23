using System;
using Aplicativo.Exercicio2;

namespace Aplicativo.Exercicios
{

    /*

    Criar uma classe pessoa com as props: nome, idade

    Criar um enum ETipoContratacao com as propriedades CLT e PJ

    Criar uma classe funcionario com as props: salario(decimal), registro empresarial(string), tipo contratacao (ETipoContratacao)

    A classe Funcionario deve herdar de pessoa 

    Criar a classe Diretor e herdar de funcionario

    Criar a classe Segurança e herdar de funcionario

    Crar a classe Recepcionista e herdar de funcionario

    Criar a interface IVigilante com o metodo de retorno vazio Vigiar()

    Criar a interface IPorteiro com o metodo de retorno vazio RegistrarEntrada()

    Criar a interface IRecepcao com o metodo de retorno vazio RegistrarVisitante()

    Criar a interface IAdministrativo com o metodo de retorno vazio AumentarSalario(Funcionario funcionario, decimal valor)

    a classe Funcionario não pode ser instanciada (criar objetos)

    o funcionario deve ter o comporatmento padrão (um método void) chamado BaterPonto()

    a classe Segurança deve implementar IRecepcao, IPorteiro, IVigilante

    a classe Recepcionista deve implementar IRecepcao

    a classe Diretor deve implementar a interface IAdministrativo

    implementar a forma de aumento de salario (pode usar a regra de negocio que quiser)

     */
    public class Execucao2
    {
        public static void Rodar()
        {

            var seguranca = new Seguranca()
            {
                Nome = "Jose",
                Idade = 45,
                Salario = 4000,
                TipoContratacao = ETipoContratacao.CLT
            };

            var recepcionista = new Recepcionista()
            {
                Nome = "Jose",
                Idade = 45,
                Salario = 4000,
                TipoContratacao = ETipoContratacao.CLT
            };

            var diretor = new Diretor()
            {
                Nome = "Azdrubal",
                Idade = 65,
                Salario = 15000,
                TipoContratacao = ETipoContratacao.CLT
            };

            diretor.AumentarSalario(seguranca, 1000);

            RegistrarPrestadorDeServico(diretor, "antonio");

        }

        public static void RegistrarPrestadorDeServico(IRecepcao qualquerUm, string nomeDoPrestador)
        {
            qualquerUm.RegistrarVisitante(nomeDoPrestador);            
        }

       
    }
}
