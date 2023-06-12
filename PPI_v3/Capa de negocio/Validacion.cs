using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    public class Validacion
    {
        public string nombre { get; set; }
        public string nroOrden { get; set; }
        public List<OpcionValidacion> listaOpcionesValidaciones { get; set; }

       

        public Validacion (string nombre, string nroOrden)
        {
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            listaOpcionesValidaciones = new List<OpcionValidacion> ();
        }

    

        public List<String> obtenerOpcionesDeValidacion()
        {
            List<String> listaOpciones = new List<String> ();
            listaOpciones.Add (this.nombre);
            foreach (OpcionValidacion opcion in this.listaOpcionesValidaciones)
            {
                listaOpciones.Add(opcion.descripcion);
            }

            return listaOpciones;
        }


    
        
       
    }
}
