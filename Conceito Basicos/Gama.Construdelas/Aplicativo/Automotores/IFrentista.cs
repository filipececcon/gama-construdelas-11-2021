using System;
namespace Aplicativo.Automotores
{
    public interface IFrentista
    {
        void Abastecer(Automovel automovel, ECombustivel combustivelDaBomba, double litros);
    }
}
