using PPI_v3.Capa_de_administracion_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    internal class CategoriaLlamada
    {
        public String mensajeOpciones { get; set; }
        public String nombre { get; set; }
        public String nroOrden { get; set; }

        public List<OpcionLlamada> listaOpcionLlamada { get; set; } 

        public CategoriaLlamada (String nombre, String nroOrden)
        {
            
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            listaOpcionLlamada = new List<OpcionLlamada> ();
        }

        public bool esTuCategoria(String nroCategoria)
        {
            if(this.nroOrden == nroCategoria)
            {
                return true;
            }
            return false;
        }

        public SubOpcionLlamada obtenerSubOpcionLlamada(String nroOpcion, String nroSubOpcion, CategoriaLlamada categoria)
        {
            OpcionLlamada opcion = obtenerOpcionLlamada(nroOpcion, categoria);
            return opcion.obtenerSubOpcionLlamada(nroSubOpcion, opcion);


        }

        public OpcionLlamada obtenerOpcionLlamada(String nroOpcion, CategoriaLlamada categoria)
        {
            foreach (OpcionLlamada opcion in categoria.listaOpcionLlamada)
            {
                if (opcion.nroOrden == nroOpcion)
                {
                    return opcion;
                }
            }
            return null;
        }



    }
}
