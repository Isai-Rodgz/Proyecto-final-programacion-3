namespace Proyecto_final 
{
    partial class FormCRUD
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblEstatusCli = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreBusc = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombreProd = new System.Windows.Forms.Label();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdadCli = new System.Windows.Forms.TextBox();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.txtNombreBusc = new System.Windows.Forms.TextBox();
            this.txtcodigoCli = new System.Windows.Forms.TextBox();
            this.txtnombreCli = new System.Windows.Forms.TextBox();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(681, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(355, 401);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 32);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(258, 401);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(73, 32);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblEstatusCli
            // 
            this.lblEstatusCli.AutoSize = true;
            this.lblEstatusCli.Location = new System.Drawing.Point(62, 332);
            this.lblEstatusCli.Name = "lblEstatusCli";
            this.lblEstatusCli.Size = new System.Drawing.Size(45, 13);
            this.lblEstatusCli.TabIndex = 23;
            this.lblEstatusCli.Text = "Estatus:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(50, 278);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 25;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(70, 239);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 21;
            this.lblEdad.Text = "Edad:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(58, 201);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombreBusc
            // 
            this.lblNombreBusc.AutoSize = true;
            this.lblNombreBusc.Location = new System.Drawing.Point(482, 89);
            this.lblNombreBusc.Name = "lblNombreBusc";
            this.lblNombreBusc.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBusc.TabIndex = 22;
            this.lblNombreBusc.Text = "Nombre:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(62, 125);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 18;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblnombreProd
            // 
            this.lblnombreProd.AutoSize = true;
            this.lblnombreProd.Location = new System.Drawing.Point(58, 163);
            this.lblnombreProd.Name = "lblnombreProd";
            this.lblnombreProd.Size = new System.Drawing.Size(47, 13);
            this.lblnombreProd.TabIndex = 17;
            this.lblnombreProd.Text = "Nombre:";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(111, 329);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(43, 20);
            this.txtEstatus.TabIndex = 29;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(111, 275);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 37);
            this.txtDireccion.TabIndex = 28;
            // 
            // txtEdadCli
            // 
            this.txtEdadCli.Location = new System.Drawing.Point(111, 236);
            this.txtEdadCli.Name = "txtEdadCli";
            this.txtEdadCli.Size = new System.Drawing.Size(100, 20);
            this.txtEdadCli.TabIndex = 27;
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.Location = new System.Drawing.Point(111, 198);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCli.TabIndex = 26;
            // 
            // txtNombreBusc
            // 
            this.txtNombreBusc.Location = new System.Drawing.Point(535, 86);
            this.txtNombreBusc.Name = "txtNombreBusc";
            this.txtNombreBusc.Size = new System.Drawing.Size(128, 20);
            this.txtNombreBusc.TabIndex = 33;
            // 
            // txtcodigoCli
            // 
            this.txtcodigoCli.Location = new System.Drawing.Point(111, 122);
            this.txtcodigoCli.Name = "txtcodigoCli";
            this.txtcodigoCli.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoCli.TabIndex = 16;
            // 
            // txtnombreCli
            // 
            this.txtnombreCli.Location = new System.Drawing.Point(111, 160);
            this.txtnombreCli.Name = "txtnombreCli";
            this.txtnombreCli.Size = new System.Drawing.Size(100, 20);
            this.txtnombreCli.TabIndex = 19;
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Location = new System.Drawing.Point(253, 122);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.Size = new System.Drawing.Size(513, 258);
            this.dtgvClientes.TabIndex = 15;
            this.dtgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClientes_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(450, 401);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 32);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(324, 21);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(190, 28);
            this.lblEtiqueta.TabIndex = 35;
            this.lblEtiqueta.Text = "CRUD de Clientes";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(693, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 32);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 471);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblEstatusCli);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreBusc);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblnombreProd);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEdadCli);
            this.Controls.Add(this.txtApellidoCli);
            this.Controls.Add(this.txtNombreBusc);
            this.Controls.Add(this.txtcodigoCli);
            this.Controls.Add(this.txtnombreCli);
            this.Controls.Add(this.dtgvClientes);
            this.Name = "FormCRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblEstatusCli;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreBusc;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombreProd;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEdadCli;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.TextBox txtNombreBusc;
        private System.Windows.Forms.TextBox txtcodigoCli;
        private System.Windows.Forms.TextBox txtnombreCli;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Button btnSalir;
    }
}

