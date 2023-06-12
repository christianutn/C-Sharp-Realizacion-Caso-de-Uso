using PPI_v3.Capa_de_administracion_de_datos;
using PPI_v3.Capa_de_negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPI_v3
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GestorRtaOperador gestoRtaOperador = new GestorRtaOperador();
            BD.iniciarDatosPrueba();

            // objetos que vienen desde caso de uso nro 1 Registrar llamada
            CategoriaLlamada categoria = BD.categoria;
            OpcionLlamada opcion = BD.opcion;
            SubOpcionLlamada subOpcion = BD.subOpcion;
            Llamada llamada = BD.llamada;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run();

            //Iniciar Caso de 
            gestoRtaOperador.opComunicarseConOperador(categoria, opcion, subOpcion, llamada);
            
        }
       
    }
    
}
