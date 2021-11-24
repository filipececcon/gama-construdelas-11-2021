using System;
using System.Collections.Generic;

namespace Aplicativo.Exercicio2
{
    public class RepositorioDeRecepcao<TRecepcao> where TRecepcao : IRecepcao
    {
        private List<TRecepcao> _funcionarios;

        public void Add(TRecepcao funcionario)
        {
            _funcionarios.Add(funcionario);
        }

    }
}
