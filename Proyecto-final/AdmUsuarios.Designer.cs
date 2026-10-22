namespace Proyecto_final
{
    partial class AdmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmUsuarios));
            this.txtID = new MyLibreria.ErrorTextBox();
            this.txtNombre = new MyLibreria.ErrorTextBox();
            this.txtcuenta = new MyLibreria.ErrorTextBox();
            this.txtcontrasena = new MyLibreria.ErrorTextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.lblestatusADM = new System.Windows.Forms.Label();
            this.lblcuenta = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new MyLibreria.ErrorTextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbbxAdm = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 136);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.SoloNumeros = true;
            this.txtID.TabIndex = 0;
            this.txtID.Validar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 186);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.SoloNumeros = false;
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validar = true;
            // 
            // txtcuenta
            // 
            this.txtcuenta.Location = new System.Drawing.Point(91, 235);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(100, 20);
            this.txtcuenta.SoloNumeros = false;
            this.txtcuenta.TabIndex = 2;
            this.txtcuenta.Validar = true;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(91, 284);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(100, 20);
            this.txtcontrasena.SoloNumeros = false;
            this.txtcontrasena.TabIndex = 3;
            this.txtcontrasena.Validar = true;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(42, 189);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(25, 287);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(64, 13);
            this.lblcontrasena.TabIndex = 5;
            this.lblcontrasena.Text = "Contraseña:";
            // 
            // lblestatusADM
            // 
            this.lblestatusADM.AutoSize = true;
            this.lblestatusADM.Location = new System.Drawing.Point(48, 341);
            this.lblestatusADM.Name = "lblestatusADM";
            this.lblestatusADM.Size = new System.Drawing.Size(39, 13);
            this.lblestatusADM.TabIndex = 6;
            this.lblestatusADM.Text = "Admin:";
            // 
            // lblcuenta
            // 
            this.lblcuenta.AutoSize = true;
            this.lblcuenta.Location = new System.Drawing.Point(41, 238);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(44, 13);
            this.lblcuenta.TabIndex = 7;
            this.lblcuenta.Text = "Cuenta:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(31, 139);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID Usuario:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 245);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(379, 94);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(86, 13);
            this.lblbuscar.TabIndex = 13;
            this.lblbuscar.Text = "Nombre Usuario:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(471, 91);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(158, 20);
            this.txtbuscar.SoloNumeros = false;
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.Validar = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(657, 89);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 14;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(117, 399);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(59, 33);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 399);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 33);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(206, 399);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 33);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(713, 394);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 42);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(225, 30);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(271, 31);
            this.lblEtiqueta.TabIndex = 19;
            this.lblEtiqueta.Text = "Administrar Usuarios";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cbbxAdm
            // 
            this.cbbxAdm.FormattingEnabled = true;
            this.cbbxAdm.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbbxAdm.Location = new System.Drawing.Point(93, 338);
            this.cbbxAdm.Name = "cbbxAdm";
            this.cbbxAdm.Size = new System.Drawing.Size(60, 21);
            this.cbbxAdm.TabIndex = 20;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(293, 399);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(59, 33);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // AdmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbbxAdm);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblcuenta);
            this.Controls.Add(this.lblestatusADM);
            this.Controls.Add(this.lblcontrasena);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Name = "AdmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmUsuarios";
            this.Load += new System.EventHandler(this.AdmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLibreria.ErrorTextBox txtID;
        private MyLibreria.ErrorTextBox txtNombre;
        private MyLibreria.ErrorTextBox txtcuenta;
        private MyLibreria.ErrorTextBox txtcontrasena;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.Label lblestatusADM;
        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblbuscar;
        private MyLibreria.ErrorTextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblEtiqueta;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbbxAdm;
        private System.Windows.Forms.Button btnNuevo;
    }
}