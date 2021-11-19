namespace Aplicativo.Exercicios
{
    class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

    }
}

