using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    public class InformacionCliente
    {
        public string datoAValidar { get; set; }    
        
        public Validacion validacion { get;set; }
        public OpcionValidacion opcionValidacion { get; set; }  
       

        public InformacionCliente (string datoAValidar)
        {
            this.datoAValidar = datoAValidar;
            
            
        }

        public bool esValidacion(Validacion validacion)
        {
            if(this.validacion.nombre == validacion.nombre)
            {
                return true;
            }
            return false;
        }

        public bool esValidacion(String nombreValidacion)
        {
            if (this.validacion.nombre == nombreValidacion)
            {
                return true;
            }
            return false;
        }

        public bool validarRepuesta(String valorAValidar)
        {
            if(valorAValidar == this.opcionValidacion.descripcion)
            {
                return true;
            }
            return false;
        }
        



    }
}
