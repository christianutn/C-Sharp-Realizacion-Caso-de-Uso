using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    internal class OpcionLlamada
    {
        public String nombre { get; set; }
        public String nroOrden { get; set; }
       
        public String mensajeSubOpcion { get; set; }    

        public List<SubOpcionLlamada> listaSubOpcionLlamada { get; set; }
        public List<Validacion> listaValidacion { get; set; }

        public OpcionLlamada (String nroOrden, String nombre)
        {
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            listaSubOpcionLlamada = new List<SubOpcionLlamada> ();
            listaValidacion = new List<Validacion> ();
        }
        public SubOpcionLlamada obtenerSubOpcionLlamada(String nroSubOpcion, OpcionLlamada opcion)
        {
            foreach (SubOpcionLlamada subOpcion in opcion.listaSubOpcionLlamada)
            {
                if(subOpcion.nroOrden == nroSubOpcion)
                {
                    return subOpcion;
                }
            }
            return null;
        }


    }
}
