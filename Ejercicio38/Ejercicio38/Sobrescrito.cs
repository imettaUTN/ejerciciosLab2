using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;
        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        public override string ToString()
        {
            return "Esto es mi metodo ToString sobreescrito";
        }
        public override bool Equals(object obj)
        {
            return obj is Sobrescrito;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }

        public abstract string MiPropiedad
        {
            get;
        }

        public abstract string MiMetodo();
    }
}
