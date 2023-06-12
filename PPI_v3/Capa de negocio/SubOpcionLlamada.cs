using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    internal class SubOpcionLlamada
    {
        public string nroOrden { get; set; }
        public string nombre { get; set; }

        public List<Validacion> listaValidacion { get; set; }
     
        public SubOpcionLlamada (string nroOrden, string nombre)
        {
            this.nroOrden = nroOrden;
            this.nombre = nombre;
            listaValidacion = new List<Validacion> ();

        }

        public List<List<String>> obtenerOpcionesDeValidacion()
        {
            List<List<String>> listOpciones = new List<List<String>> ();

            foreach (Validacion val in this.listaValidacion)
            {

                listOpciones.Add(val.obtenerOpcionesDeValidacion());
            }
            return listOpciones;
        }
      
    }
}
