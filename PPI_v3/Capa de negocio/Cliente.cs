using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI_v3.Capa_de_negocio
{
    internal class Cliente
    {
        public string nroCliente { get; set; }
        public string tipoDoc { get; set; }
        public string nroDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nroCelular { get; set; }

        public List<InformacionCliente> listaInformacionCliente { get; set; }

        

        public Cliente (string nroCliente, string tipoDoc, string nroDoc, string nombre, string apellido, string nroCelular)
        {
            this.nroCliente = nroCliente;
            this.tipoDoc = tipoDoc;
            this.nroDoc = nroDoc;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nroCelular = nroCelular;
            listaInformacionCliente = new List<InformacionCliente> ();
        }

        public InformacionCliente obtenerInfoCliente(Validacion validacion)
        {
            
            foreach(InformacionCliente infoCliente in listaInformacionCliente)
            {
                if (infoCliente.esValidacion(validacion))
                {
                    return infoCliente;
                }
            }
            return null;
            
        }

        public bool validarRepuesta(String nombreValidacion, String valorAValidar)
        {
            foreach(InformacionCliente infoCliente in this.listaInformacionCliente)
            {
                if(infoCliente.esValidacion(nombreValidacion))
                {
                    return infoCliente.validarRepuesta(valorAValidar);
                }
            }
            return false;
        }


    
    }
}
