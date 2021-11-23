using System;
namespace Aplicativo.Generics
{
    public abstract class Fruta
    {
        protected Fruta(bool temCascaGrossa, bool temCaroco)
        {
            TemCascaGrossa = temCascaGrossa;
            TemCaroco = temCaroco;
        }

        public bool TemCascaGrossa { get; protected set; }
        public bool TemCaroco { get; protected set; }
    }
}
