using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {

        private List<Llamada> listaDeLLamadas;
        private string razonSocial;

        public Centralita()
        {
            listaDeLLamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public void OrdenarLlamadas()
        {
            listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social:" + razonSocial);
            sb.AppendLine("Ganancia total" + GananciaPorTotal);
            sb.AppendLine("Ganancia Local" + GananciaPorLocal);
            sb.AppendLine("Ganancia provincia" + GananciaPorProvincia);
            foreach( Llamada llamada in listaDeLLamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }
            return sb.ToString();
        }
        public float CalcularGanancia(Llamada.TipoLlamada tipo)
        {

            float costoLocal = 0;
            float costoProvincia = 0;
            foreach (Llamada llamada in listaDeLLamadas)
            {
                if (llamada is Local)
                {
                    costoLocal += ((Local)llamada).CostoLlamada;
                }
                else if (llamada is Provincial)
                {
                    costoProvincia += ((Provincial)llamada).CostoLlamada;

                }
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return costoLocal;
                case Llamada.TipoLlamada.Provincial:
                    return costoProvincia;
                default:
                    return costoProvincia + costoLocal;
            }
             }
        #region Propiedades
        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincia
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLLamadas;
            }
        }
        #endregion
    }
}
