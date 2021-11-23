using System;
namespace Aplicativo.Exercicio2
{
    public abstract class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string RegistroEmpresarial { get; set; }
        public ETipoContratacao TipoContratacao { get; set; }

        public void BaterPonto()
        {

        }
    }
}
