using PPI_v3.Capa_de_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPI.Capa_de_presentacion
{
    partial class PantallaDescripcion : Form
    {
        GestorRtaOperador gestor;
        
        public PantallaDescripcion(GestorRtaOperador gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            cargarComboBox(gestor.obtenerListaAcciones());
            cmbAcciones.SelectedIndex = -1;
            cmbAcciones.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void PantallaDescripcion_Load(object sender, EventArgs e)
        {
             
        }

        public void cargarComboBox(List<Accion> listaAccion)
        {

            // Asigna la lista de elementos al DataSource del ComboBox
            cmbAcciones.DataSource = listaAccion;

            // Configura la propiedad DisplayMember para especificar la propiedad del objeto que se mostrará en la lista desplegable
            cmbAcciones.DisplayMember = "descripcion";

            // Configura la propiedad ValueMember para especificar la propiedad del objeto que se utilizará como valor seleccionado
            cmbAcciones.ValueMember = "descripcion";
        }

        private void cmbAcciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTxtDescripcion.Focus();
        }

        public Accion tomarAccion()
        {
            return cmbAcciones.SelectedItem as Accion;
        }
        
        public String tomarDescripcion()
        {
            return richTxtDescripcion.Text;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(cmbAcciones.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una acción a realizar!!!");
                cmbAcciones.Focus();
                cmbAcciones.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else if (richTxtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción de su repuesta!!!");
                richTxtDescripcion.Focus();
            }
            else
            {
                DialogResult res = MessageBox.Show("¿Estás seguro de confirmar?", "Confirmar", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (gestor.llamarCURegAccionRequerida())
                    {


                        gestor.tomarAccion(tomarAccion());
                        gestor.tomarDescripcion(tomarDescripcion());

                        gestor.finalizarLlamada("Finalizada");
                        this.Close();
                        MessageBox.Show("Repuesta generada con éxito!!!");

                        // Comprobar datos finales
                        // Llamada verDatosFinales = gestor.llamada;


                    }

                }

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente cortó la llamada. \n La llamada se cierra como Cancelada", "Llamada Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            gestor.finalizarLlamada("Cancelada");
            this.Close();
            // Comprobar datos finales
             // Llamada verDatosFinales = gestor.llamada;
        }
    }
}
