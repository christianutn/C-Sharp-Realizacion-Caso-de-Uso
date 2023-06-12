namespace PPI_v3
{
    partial class PantallaRtaOperador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblSubOpcion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.txtNroOrdOpcion = new System.Windows.Forms.TextBox();
            this.txtNroOrdSubOp = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreOp = new System.Windows.Forms.TextBox();
            this.txtNombreSubOp = new System.Windows.Forms.TextBox();
            this.txtNroOrdCat = new System.Windows.Forms.TextBox();
            this.flwValidaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(17, 44);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(140, 16);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría de llamada:";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(17, 85);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(124, 16);
            this.lblOpcion.TabIndex = 1;
            this.lblOpcion.Text = "Opcion de llamada:";
            // 
            // lblSubOpcion
            // 
            this.lblSubOpcion.AutoSize = true;
            this.lblSubOpcion.Location = new System.Drawing.Point(17, 131);
            this.lblSubOpcion.Name = "lblSubOpcion";
            this.lblSubOpcion.Size = new System.Drawing.Size(151, 16);
            this.lblSubOpcion.TabIndex = 2;
            this.lblSubOpcion.Text = "Sub Opcion de llamada:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Enabled = false;
            this.txtNombreCat.Location = new System.Drawing.Point(222, 41);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(305, 22);
            this.txtNombreCat.TabIndex = 9;
            // 
            // txtNroOrdOpcion
            // 
            this.txtNroOrdOpcion.Enabled = false;
            this.txtNroOrdOpcion.Location = new System.Drawing.Point(174, 82);
            this.txtNroOrdOpcion.Name = "txtNroOrdOpcion";
            this.txtNroOrdOpcion.Size = new System.Drawing.Size(24, 22);
            this.txtNroOrdOpcion.TabIndex = 10;
            // 
            // txtNroOrdSubOp
            // 
            this.txtNroOrdSubOp.Enabled = false;
            this.txtNroOrdSubOp.Location = new System.Drawing.Point(174, 128);
            this.txtNroOrdSubOp.Name = "txtNroOrdSubOp";
            this.txtNroOrdSubOp.Size = new System.Drawing.Size(24, 22);
            this.txtNroOrdSubOp.TabIndex = 11;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(17, 183);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(182, 16);
            this.lblNombreCliente.TabIndex = 12;
            this.lblNombreCliente.Text = "Nombre completo del cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(222, 180);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(305, 22);
            this.txtNombreCliente.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNroOrdOpcion);
            this.groupBox1.Controls.Add(this.txtNombreOp);
            this.groupBox1.Controls.Add(this.txtNombreSubOp);
            this.groupBox1.Controls.Add(this.txtNroOrdCat);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.txtNroOrdSubOp);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.lblSubOpcion);
            this.groupBox1.Controls.Add(this.lblOpcion);
            this.groupBox1.Controls.Add(this.txtNombreCat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(25, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 231);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la llamada";
            // 
            // txtNombreOp
            // 
            this.txtNombreOp.Enabled = false;
            this.txtNombreOp.Location = new System.Drawing.Point(222, 82);
            this.txtNombreOp.Name = "txtNombreOp";
            this.txtNombreOp.Size = new System.Drawing.Size(305, 22);
            this.txtNombreOp.TabIndex = 15;
            // 
            // txtNombreSubOp
            // 
            this.txtNombreSubOp.Enabled = false;
            this.txtNombreSubOp.Location = new System.Drawing.Point(222, 128);
            this.txtNombreSubOp.Name = "txtNombreSubOp";
            this.txtNombreSubOp.Size = new System.Drawing.Size(305, 22);
            this.txtNombreSubOp.TabIndex = 16;
            // 
            // txtNroOrdCat
            // 
            this.txtNroOrdCat.Enabled = false;
            this.txtNroOrdCat.Location = new System.Drawing.Point(174, 41);
            this.txtNroOrdCat.Name = "txtNroOrdCat";
            this.txtNroOrdCat.Size = new System.Drawing.Size(24, 22);
            this.txtNroOrdCat.TabIndex = 14;
            // 
            // flwValidaciones
            // 
            this.flwValidaciones.AutoScroll = true;
            this.flwValidaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwValidaciones.Location = new System.Drawing.Point(25, 315);
            this.flwValidaciones.Name = "flwValidaciones";
            this.flwValidaciones.Size = new System.Drawing.Size(621, 203);
            this.flwValidaciones.TabIndex = 16;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(388, 538);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(114, 32);
            this.btnValidar.TabIndex = 17;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(527, 538);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 32);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Llamada Cortada";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Validaciones:";
            // 
            // PantallaRtaOperador
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(674, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.flwValidaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PantallaRtaOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de operador";
            this.Load += new System.EventHandler(this.PantallaRtaOperador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblSubOpcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.TextBox txtNroOrdOpcion;
        private System.Windows.Forms.TextBox txtNroOrdSubOp;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flwValidaciones;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombreSubOp;
        private System.Windows.Forms.TextBox txtNombreOp;
        private System.Windows.Forms.TextBox txtNroOrdCat;
        private System.Windows.Forms.Label label1;
    }
}

