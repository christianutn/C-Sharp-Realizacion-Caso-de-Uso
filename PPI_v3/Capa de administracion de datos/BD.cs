using PPI.Capa_de_negocio;
using PPI_v3.Capa_de_negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPI_v3.Capa_de_administracion_de_datos
{
    internal class BD
    {
        public static List<Cliente> listaClientes;
        public static List<CategoriaLlamada> listaCategorias;
        public static List<OpcionLlamada> listaOpcionesLlamadas;
        public static List<SubOpcionLlamada> listaSubOpcionesLlamadas;
        public static List<Estado> listaEstados;
        public static List<Accion> listaAcciones;
        public static List<InformacionCliente> listaInformacionesClientes;
        public static List<Llamada> listaLlamadas;
        public static List<Validacion> listaValidaciones;
        public static List<OpcionValidacion> listaOpcionesValidaciones;
        public static CategoriaLlamada categoria;
        public static OpcionLlamada opcion;
        public static SubOpcionLlamada subOpcion;
        public static Llamada llamada;
        public static List<Usuario> listaUsuarios;

        public BD()
        {
            listaClientes = new List<Cliente>();
            listaCategorias = new List<CategoriaLlamada>();
            listaOpcionesLlamadas = new List<OpcionLlamada>();
            listaSubOpcionesLlamadas = new List<SubOpcionLlamada>();
            listaEstados = new List<Estado>();
            listaAcciones = new List<Accion>();
            listaInformacionesClientes = new List<InformacionCliente>();
            listaLlamadas = new List<Llamada>();
            listaValidaciones = new List<Validacion>();
            listaOpcionesValidaciones = new List<OpcionValidacion>();
            listaUsuarios = new List<Usuario>();
        }

        public static void iniciarDatosPrueba()
        {
            BD datosDePrueba = new BD();


            // Dtos de la llamada
            Cliente cliente = new Cliente("999", "dni", "32333444", "Messi", "Lionel", "3512333444");

            categoria = new CategoriaLlamada("Informar Denuncia Tarjeta de Crédito", "1");
            opcion = new OpcionLlamada("1", "Por robo o extravío");
            subOpcion = new SubOpcionLlamada("1", "Hablar con un Operador");

            Validacion valCantHijos = new Validacion("Cantidad de Hijos", "1");
            Validacion valCodPostal = new Validacion("Código Postal", "2");
            Validacion valAmigoInfancia = new Validacion("Nombre amigo de la infancia", "3");
            Validacion valNombreAbueloPaterno = new Validacion("Nombre abuelo paterno", "4");



            llamada = new Llamada("1010", cliente);



            //Lista estados en curso

            Estado estadoEnCurso = new Estado("EnCurso");
            Estado estadoFinalizada = new Estado("Finalizada");
            Estado estadoCancelada = new Estado("Cancelada");
            Estado estadoIniciada = new Estado("Iniciada");

            listaEstados.Add(estadoEnCurso);
            listaEstados.Add(estadoIniciada);
            listaEstados.Add(estadoFinalizada);
            listaEstados.Add(estadoCancelada);


            //Vincular validacion con subopcion

            subOpcion.listaValidacion.Add(valCantHijos);
            subOpcion.listaValidacion.Add(valCodPostal);
            // subOpcion.listaValidacion.Add(valAmigoInfancia);
            //subOpcion.listaValidacion.Add(valNombreAbueloPaterno);

            // Vincular cada validacion con las opciones de validacion

            OpcionValidacion opVal_cantHijos1 = new OpcionValidacion("1");
            OpcionValidacion opVal_cantHijos2 = new OpcionValidacion("2");
            OpcionValidacion opVal_cantHijos3 = new OpcionValidacion("3");
            valCantHijos.listaOpcionesValidaciones.Add(opVal_cantHijos1);
            valCantHijos.listaOpcionesValidaciones.Add(opVal_cantHijos2);
            valCantHijos.listaOpcionesValidaciones.Add(opVal_cantHijos3);



            OpcionValidacion opVal_codPostal1 = new OpcionValidacion("5008");
            OpcionValidacion opVal_codPostal2 = new OpcionValidacion("5000");
            OpcionValidacion opVal_codPostal3 = new OpcionValidacion("5005");
            valCodPostal.listaOpcionesValidaciones.Add(opVal_codPostal1);
            valCodPostal.listaOpcionesValidaciones.Add(opVal_codPostal2);
            valCodPostal.listaOpcionesValidaciones.Add(opVal_codPostal3);


            OpcionValidacion opVal_amigo1 = new OpcionValidacion("Pedro");
            OpcionValidacion opVal_amigo2 = new OpcionValidacion("Juan");
            OpcionValidacion opVal_amigo3 = new OpcionValidacion("Florencia");
            valAmigoInfancia.listaOpcionesValidaciones.Add(opVal_amigo1);
            valAmigoInfancia.listaOpcionesValidaciones.Add(opVal_amigo2);
            valAmigoInfancia.listaOpcionesValidaciones.Add(opVal_amigo3);


            OpcionValidacion opVal_nombreAbuelo1 = new OpcionValidacion("Nestor");
            OpcionValidacion opVal_nombreAbuelo2 = new OpcionValidacion("Oscar");
            OpcionValidacion opVal_nombreAbuelo3 = new OpcionValidacion("Raul");
            valNombreAbueloPaterno.listaOpcionesValidaciones.Add(opVal_nombreAbuelo1);
            valNombreAbueloPaterno.listaOpcionesValidaciones.Add(opVal_nombreAbuelo2);
            valNombreAbueloPaterno.listaOpcionesValidaciones.Add(opVal_nombreAbuelo3);
            //Marcar opciones correctas

            opVal_cantHijos1.correcta = true;
            opVal_codPostal1.correcta = true;

            // Vincular cliente con informacion cliente

            InformacionCliente infoCantHijos = new InformacionCliente("Cantidad de Hijos");
            infoCantHijos.opcionValidacion = opVal_cantHijos1;
            infoCantHijos.validacion = valCantHijos;
            cliente.listaInformacionCliente.Add(infoCantHijos);

            InformacionCliente infoCodPostal = new InformacionCliente("Cantidad de Hijos");
            infoCodPostal.opcionValidacion = opVal_codPostal1;
            infoCodPostal.validacion = valCodPostal;
            cliente.listaInformacionCliente.Add(infoCodPostal);

            //Agregamos informacion de cliente a modo de prueba

            InformacionCliente infoClienteDeMas = new InformacionCliente("Amigo de la infancia");
            InformacionCliente infoClienteDeMas2 = new InformacionCliente("Escuela secundaria");

            //Creamos Usuario 

            Usuario usuario = new Usuario(true, DateTime.Parse("01/01/2020"), "luisPerez", "123");

            //Crear lista de acciones

            listaAcciones.Add(new Accion("Denunciar Tarjeta de Crédito"));
            listaAcciones.Add(new Accion("Consultar Saldo Tarjeta de Crédito"));
            listaAcciones.Add(new Accion("Consultar Por Baja de Tarjeta de Crédito"));
            listaAcciones.Add(new Accion("Solicitar Adicional a Tarjeta de Crédito"));

            //Al iniciar la llamada debe crearse el primer cambio de estado con Iniciada

            llamada.cambiosDeEstados.Add(new CambioEstado(DateTime.Now, estadoIniciada));


        }



        public static Estado obtenerEstado(String nombreEstado)
        {
            foreach (Estado estado in listaEstados)
            {
                if (estado.esTuEstado(nombreEstado))
                {
                    return estado;
                }
            }
            return null;
        }

        public static Usuario obtenerUsuario(String nombreUsuario)
        {

            foreach (Usuario usu in listaUsuarios)
            {
                if (nombreUsuario == usu.nombreUsuario)
                {
                    return usu;
                }
            }

            return null;

        }


    }
}
