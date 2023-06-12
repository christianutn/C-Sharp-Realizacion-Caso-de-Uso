using PPI.Capa_de_negocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPI_v3.Capa_de_negocio
{
    internal class Llamada
    {
        public String idLlamada { get; set; }
        public String descripcionOperador { get; set; }
        public TimeSpan duracion { get; set; }

        public List<CambioEstado> cambiosDeEstados { get; set; }

        public Cliente cliente { get; set; }

        public OpcionLlamada opcionLlamada { get; set; }
        public SubOpcionLlamada subOpcionLlamada { get; set; }
        public Accion accion { get; set; }

        public Usuario usuario {get; set;}

        public Llamada (String idLlamada, Cliente cliente)
        {
            this.idLlamada = idLlamada;
            cambiosDeEstados = new List<CambioEstado>();
            this.cliente = cliente;
           
        }
       
        
        public void setDescripcionLlamada(String descripcionOperador)
        {
            this.descripcionOperador = descripcionOperador.Trim();
        }
        public void setDuracion(TimeSpan duracion)
        {
            this.duracion = duracion;
        }

        public int calcularDuracion(DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            TimeSpan duracion = fechaHoraFin - fechaHoraInicio;
            int duracionSegundos = (int)duracion.TotalSeconds;
            return duracionSegundos;
        }

        public bool esTuLlamada(String idLlamada)
        {
            if (this.idLlamada == idLlamada)
            {
                return true;
            }

            return false;
        }

        public void setEstadoActual(Estado estadoActual)
        {
            DateTime fechaHoraActual = DateTime.Now;
            crearCambioEstado(fechaHoraActual, estadoActual);
        }

        public void crearCambioEstado(DateTime fechaHoraInicio, Estado estadoActual)
        {
            this.cambiosDeEstados.Add(new CambioEstado(fechaHoraInicio, estadoActual));
        }

        public String getNombreClienteDeLlamada()
        {
            String nombre = this.cliente.nombre;
            String apellido = this.cliente.apellido;

            return nombre + " " + apellido;
        }

        public InformacionCliente obtenerInfoCliente(Validacion validacion)
        {
            return this.cliente.obtenerInfoCliente(validacion); 
        }

       public List<List<String>> obtenerOpcionesDeValidacion(SubOpcionLlamada subOpcionLlamada)
        {
            return subOpcionLlamada.obtenerOpcionesDeValidacion();
        }
       
        public bool validarRepuesta(String nombreValidacion, String valorAValidar)
        {
           return cliente.validarRepuesta(nombreValidacion, valorAValidar);
        }
       
        public void asociarUsuarioALlamada(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public DateTime obtenerFechaHoraInicio(Estado estado)
        {
           
            foreach (CambioEstado cbioEstado in this.cambiosDeEstados)
            {
                
                if(cbioEstado.esTuEstado(cbioEstado.estado))
                {
                    return  cbioEstado.fechaHoraInicio;
                }
            }
            
            return DateTime.MinValue;
        }

        public void asociarRtaOperador(String descripcionOperador)
        {
           this.descripcionOperador = descripcionOperador;
        }

        public void asociarAccion(Accion accionSeleccionada)
        {
            this.accion = accionSeleccionada;
        }


    }


}