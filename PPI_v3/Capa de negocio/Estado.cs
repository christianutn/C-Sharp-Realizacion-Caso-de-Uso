using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    internal class Estado
    {
        public String nombre { get; set; }

        public Estado(String nombre)
        {
            this.nombre = nombre;
        }

        public bool esTuEstado(String nombreEstado) 
        {
            if (this.nombre == nombreEstado)
            {
                return true;
            }

            return false;
        }

        public bool esTuEstado(Estado estado)
        {
            if (this == estado)
            {
                return true;
            }

            return false;
        }

    }
}
