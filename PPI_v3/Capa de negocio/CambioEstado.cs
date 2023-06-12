using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    internal class CambioEstado
    {
        public DateTime fechaHoraInicio { get; set; }
        public Estado estado { get; set; }

        public CambioEstado (DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }

        public bool esTuEstado(Estado estado)
        {
            return estado.esTuEstado(estado);
        }
      
    }
}
