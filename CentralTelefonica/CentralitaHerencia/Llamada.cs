using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }
        #region Propiedades
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        #endregion
        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("duracion :" + this.Duracion);
            sb.AppendLine("Nro destinto :" + this.NroDestino);
            sb.AppendLine("Nro origen :" + this.NroDestino);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada2.duracion - llamada1.duracion);        
        }


        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
