using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        private Franja franjaHoraria;

        public Provincial(string origen, Franja franja, float duracion, string destino) : base(duracion, destino, origen)
        {
            franjaHoraria = franja;
        }     
        public Provincial(Franja franja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            franjaHoraria = franja;
        }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1: costo = 0.99F; break;
                case Franja.Franja_2: costo = 1.25F; break;
                case Franja.Franja_3: costo = 0.66F; break;

            }
            return costo * Duracion;        
        }
        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine(" Costo llamada: " + CostoLlamada);
            sb.AppendLine(" Franja horaria :" + franjaHoraria);
            return sb.ToString();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
