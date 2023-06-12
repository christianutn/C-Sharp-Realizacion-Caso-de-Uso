using PPI.Capa_de_presentacion;
using PPI_v3.Capa_de_administracion_de_datos;
using PPI_v3.Capa_de_negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PPI_v3
{

    partial class PantallaRtaOperador : Form
    {

        public List<List<String>> listaOpciones;
        public GestorRtaOperador gestorRtaOperador;
       

       
        public PantallaRtaOperador(CategoriaLlamada categoria, OpcionLlamada opcion, SubOpcionLlamada subOpcion, List<List<String>> listaOpciones, GestorRtaOperador gestor)
        {
            InitializeComponent();
               
            this.gestorRtaOperador = gestor;
            this.listaOpciones = listaOpciones;
            mostrarDatosLlamada(categoria, opcion, subOpcion);
            mostrarValidaciones(listaOpciones);

        }

        
        private void PantallaRtaOperador_Load(object sender, EventArgs e)
        {
            
        }

        public void mostrarDatosLlamada(CategoriaLlamada categoria, OpcionLlamada opcion, SubOpcionLlamada subOpcion)
        {
            txtNombreCat.Text = categoria.nombre;
            txtNroOrdCat.Text = categoria.nroOrden;

            txtNombreOp.Text = opcion.nombre;
            txtNroOrdOpcion.Text = opcion.nroOrden;

            txtNombreSubOp.Text = subOpcion.nombre;
            txtNroOrdSubOp.Text = subOpcion.nroOrden;

            txtNombreCliente.Text = gestorRtaOperador.obtenerNombreCliente();

        }

        public GroupBox crearGroupBox(String nombreValidacion, String nombreGpb)
        {
            

            GroupBox groupBox = new GroupBox();
            groupBox.Text = nombreValidacion;
            groupBox.Width = flwValidaciones.Width - 20;
            
            groupBox.Name = nombreGpb;
          
            groupBox.Height += 10;
            return groupBox;
        }

        public RadioButton crearRadioButton(String datoAValidar, String nombreRd)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Dock = DockStyle.Top;
            radioButton.Height += 10;
            radioButton.Text = datoAValidar;
            radioButton.Name = nombreRd;
            

            return radioButton;
        }

        
          public void mostrarValidaciones(List<List<String>> listaOpciones)
           {

               foreach (List<String> lista in listaOpciones)
               {
                   GroupBox gpb = new GroupBox();
                   for (int i = 0; i < lista.Count; i++)
                   {

                       if (i == 0)
                       {
                           String nombreValidacion = lista[0].ToString();
                           gpb = crearGroupBox(nombreValidacion, "gpb"+nombreValidacion);
                           gpb.Margin = new Padding(0, 0, 0, 20);
                           flwValidaciones.Controls.Add(gpb);  
                       }
                       else
                       {
                           String valorDeOpcion = lista[i].ToString();
                           RadioButton radioButton = crearRadioButton(valorDeOpcion, "rd"+i);
                           gpb.Controls.Add(radioButton);

                       }
                   }
               }

           }

           public List<List<String>> tomarRepuestas(FlowLayoutPanel flw)
           {
               List<List<String>> repuestas = new List<List<String>>();
            foreach (Control control in flwValidaciones.Controls.OfType<GroupBox>())
            {
                foreach (Control control2 in control.Controls.OfType<RadioButton>())
                {
                    if (((RadioButton)control2).Checked) // Verifica si el radiobutton está seleccionado
                    {
                        // Realiza la acción correspondiente con el radiobutton seleccionado
                        List<string> rep = new List<string>();
                        rep.Add(control.Text);
                        rep.Add(control2.Text);
                        repuestas.Add(rep);
                    }
                }
            }
            return repuestas;
           }
            
           public bool existePorCadaGroupBoxUnRadioButton()
        {
            bool todosSeleccionados = true;
            foreach (GroupBox groupBox in flwValidaciones.Controls.OfType<GroupBox>())
            {
                bool alMenosUnoSeleccionado = groupBox.Controls.OfType<RadioButton>().Any(radioButton => radioButton.Checked);
                if (!alMenosUnoSeleccionado)
                {
                    todosSeleccionados = false;
                    break;
                }
            }
            return todosSeleccionados;
        }

           

      


        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (existePorCadaGroupBoxUnRadioButton())
            {
                List<List<String>> listaRepuestas = gestorRtaOperador.tomarRepuestas(tomarRepuestas(flwValidaciones));

                bool resultadoValidaciones = gestorRtaOperador.validarRepuestas(listaRepuestas);


                if (resultadoValidaciones)
                {
                    gestorRtaOperador.habilitarPantDescripcion();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Cliente no superó las pruebas de validación. \n La llamada se cierra como Cancelada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    gestorRtaOperador.finalizarLlamada("Cancelada");
                    this.Close();
                }

            }else
            {
                MessageBox.Show("Faltan validaciones para responder", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente cortó la llamada. \n La llamada se cierra como Cancelada", "Llamada Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            gestorRtaOperador.finalizarLlamada("Cancelada");
            this.Close();
        }
    }
}
