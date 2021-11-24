using System;
using System.Collections.Generic;

namespace Aplicativo.Generics
{
    /*
     
    podemos restringir o tipo generico para tipos que herdem de uma determinada classe

     */

    public class RepositorioDeFrutas<TFruta> where TFruta : Fruta
    {
        private List<TFruta> _frutas;

        public void Add(TFruta fruta)
        {
            _frutas.Add(fruta);
        }


        public void Remove(TFruta fruta)
        {
            _frutas.Remove(fruta);
        }
    }

    //public class RepositorioMelancia
    //{
    //    private List<Melancia> _frutas;

    //    public void Add(Melancia fruta)
    //    {
    //        _frutas.Add(fruta);
    //    }

    //}


}
