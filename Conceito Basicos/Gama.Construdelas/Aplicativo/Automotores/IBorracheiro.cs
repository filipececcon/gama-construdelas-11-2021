using System;
namespace Aplicativo.Automotores
{
    public interface IBorracheiro
    {
        void CalibrarPneus(Automovel automovel);

        void TrocarRoda(Automovel automovel);

    }
}
