using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    public class OpcionValidacion
    {
        public bool correcta { get; set; }
        public String descripcion { get; set; }

       public OpcionValidacion(String descripcion)  
        {
            this.descripcion = descripcion;
            this.correcta = false;
        }

        
    }
}
