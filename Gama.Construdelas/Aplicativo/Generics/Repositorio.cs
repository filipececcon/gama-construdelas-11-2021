using System;
using System.Collections.Generic;

namespace Aplicativo.Generics
{
    public class Repositorio
    {
        private List<Fruta> _frutas;

        public void Add(Fruta fruta)
        {
            _frutas.Add(fruta);
        }

    }
}
