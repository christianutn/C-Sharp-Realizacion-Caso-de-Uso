using PPI.Capa_de_negocio;
using PPI.Capa_de_presentacion;
using PPI_v3.Capa_de_administracion_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPI_v3.Capa_de_negocio
{
    class GestorRtaOperador
    {
        public CategoriaLlamada categoria { get; set; }
        public OpcionLlamada opcion { get; set; }
        public SubOpcionLlamada subOpcion { get; set; }
        public Llamada llamada { get; set; }

        public String nombreUsuario { get; set; }

        public GestorRtaOperador()
        {
            this.categoria = categoria;
            this.opcion = opcion;
            this.subOpcion = subOpcion;
            this.llamada = llamada;

        }

        public void opComunicarseConOperador(CategoriaLlamada categoria, OpcionLlamada opcion, SubOpcionLlamada subOpcion, Llamada llamada)
        {
            this.categoria = categoria;
            this.opcion = opcion;
            this.subOpcion = subOpcion;
            this.llamada = llamada;
          
            


            //Asociar SubOpcion a Llamada
            if (tieneSubOpcion())
            {
                asociarSubOpALlamada();
            }
            

            //Asociar Usuario a Llamada

          //  asociarUsuarioALlamada(obtenerUsuario(nombreUsuario)); // podemos sacar?? 
  

            //Actualizar llamada a estado en curso

            actualizarLlamadaANuevoEstado(obtenerEstado("EnCurso"));

    
            //Mostrar validaciones

            habilitarPantRtaOperador();


        }

        public Estado obtenerEstado(String nombreEstado)
        {
            return BD.obtenerEstado(nombreEstado);
        }


        public void actualizarLlamadaANuevoEstado(Estado estado)
        {
            llamada.setEstadoActual(estado);

        }
       


        public Usuario obtenerUsuario(String nombreUsuairo)
        {
            return BD.obtenerUsuario(nombreUsuario);
        }

        public void asociarUsuarioALlamada(Usuario usuario)
        {
            llamada.asociarUsuarioALlamada(usuario);
        }
       
     

        public String obtenerNombreCliente()
        {
            return llamada.getNombreClienteDeLlamada();
        }



        public bool tieneSubOpcion()
        {
            return this.subOpcion != null;
        }



        public void asociarSubOpALlamada()
        {
            llamada.subOpcionLlamada = subOpcion;
        }

        public List<List<String>> obtenerOpcionesDeValidacion()
        {
            return llamada.obtenerOpcionesDeValidacion(llamada.subOpcionLlamada);
        }


        public List<List<String>> tomarRepuestas(List<List<String>> listaRepuestas)
        {
            return listaRepuestas.ToList();
        }




        public bool validarRepuestas(List<List<String>> listaRepuestas)
        {

            foreach (List<String> item in listaRepuestas)
            {
                String nombreValidacion = item[0].ToString();
                String valorAValidar = item[1].ToString();  

                if( !llamada.validarRepuesta(nombreValidacion, valorAValidar ))
                {
                    return false;
                }
            }
            return true;
        }


        public List<Accion> obtenerListaAcciones()
        {
            return BD.listaAcciones;
        }

        public void habilitarPantRtaOperador()
        {
            PantallaRtaOperador pantalla = new PantallaRtaOperador(categoria, opcion, subOpcion, obtenerOpcionesDeValidacion(), this);

            pantalla.ShowDialog();
        }

        public void habilitarPantDescripcion()
        {
            MessageBox.Show("Los datos han sido validados correctamente", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PantallaDescripcion pantallaDescripcion = new PantallaDescripcion(this);

            pantallaDescripcion.ShowDialog();
        }

        public bool llamarCURegAccionRequerida()
        {
            return true;
        }

       
        public DateTime obtenerFechaHoraInicio(Estado estado) 
        {
            return llamada.obtenerFechaHoraInicio(estado);

        }

        public TimeSpan calcularDuracion(DateTime fechaHoraInicioIniciada, DateTime fechaHoraFinFinalizada)
        {
            TimeSpan res = fechaHoraFinFinalizada - fechaHoraInicioIniciada;

            return res;
        }

        public void setDuracion(TimeSpan duracion)
        {
            llamada.setDuracion(duracion);

        }

        public void finalizarLlamada(String nombreEstadoAFinalizar)
        {
            actualizarLlamadaANuevoEstado(obtenerEstado(nombreEstadoAFinalizar));

            DateTime fechaHoraFinFinalizada = obtenerFechaHoraInicio(obtenerEstado(nombreEstadoAFinalizar));

            DateTime fechaHoraFinIniciada = obtenerFechaHoraInicio(obtenerEstado("Iniciada"));

            setDuracion( calcularDuracion(fechaHoraFinIniciada, fechaHoraFinFinalizada));
        }


        
        public void tomarDescripcion(String descripcion)
        {
           llamada. asociarRtaOperador(descripcion);
        }

     

       public void tomarAccion( Accion accionSeleccionada)
        {
            llamada.asociarAccion(accionSeleccionada);
        }
        


    }


}
