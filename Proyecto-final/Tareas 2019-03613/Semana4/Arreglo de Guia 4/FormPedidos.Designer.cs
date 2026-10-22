namespace Proyecto_final 
{
    partial class FormPedidos
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
            this.btnLimpiarP = new System.Windows.Forms.Button();
            this.lblEtiquetaPed = new System.Windows.Forms.Label();
            this.cbbxIDClie = new System.Windows.Forms.ComboBox();
            this.dtmpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblCantLib = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.btnIngresarP = new System.Windows.Forms.Button();
            this.btnVolverP = new System.Windows.Forms.Button();
            this.nudwCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblNombreLib = new System.Windows.Forms.Label();
            this.lblIDLibro = new System.Windows.Forms.Label();
            this.cbbxIDLibro = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscarPed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudwCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarP
            // 
            this.btnLimpiarP.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarP.Location = new System.Drawing.Point(162, 389);
            this.btnLimpiarP.Name = "btnLimpiarP";
            this.btnLimpiarP.Size = new System.Drawing.Size(75, 33);
            this.btnLimpiarP.TabIndex = 0;
            this.btnLimpiarP.Text = "Limpiar";
            this.btnLimpiarP.UseVisualStyleBackColor = true;
            this.btnLimpiarP.Click += new System.EventHandler(this.btnLimpiarP_Click);
            // 
            // lblEtiquetaPed
            // 
            this.lblEtiquetaPed.AutoSize = true;
            this.lblEtiquetaPed.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaPed.Location = new System.Drawing.Point(31, 21);
            this.lblEtiquetaPed.Name = "lblEtiquetaPed";
            this.lblEtiquetaPed.Size = new System.Drawing.Size(118, 35);
            this.lblEtiquetaPed.TabIndex = 1;
            this.lblEtiquetaPed.Text = "Pedidos";
            // 
            // cbbxIDClie
            // 
            this.cbbxIDClie.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxIDClie.FormattingEnabled = true;
            this.cbbxIDClie.Location = new System.Drawing.Point(100, 99);
            this.cbbxIDClie.Name = "cbbxIDClie";
            this.cbbxIDClie.Size = new System.Drawing.Size(121, 27);
            this.cbbxIDClie.TabIndex = 3;
            this.cbbxIDClie.SelectedIndexChanged += new System.EventHandler(this.cbbxIDClie_SelectedIndexChanged);
            // 
            // dtmpFecha
            // 
            this.dtmpFecha.Location = new System.Drawing.Point(87, 330);
            this.dtmpFecha.Name = "dtmpFecha";
            this.dtmpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtmpFecha.TabIndex = 4;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(22, 102);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(72, 19);
            this.lblClienteID.TabIndex = 5;
            this.lblClienteID.Text = "ID Cliente:";
            // 
            // lblCantLib
            // 
            this.lblCantLib.AutoSize = true;
            this.lblCantLib.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLib.Location = new System.Drawing.Point(33, 276);
            this.lblCantLib.Name = "lblCantLib";
            this.lblCantLib.Size = new System.Drawing.Size(131, 19);
            this.lblCantLib.TabIndex = 6;
            this.lblCantLib.Text = "Cantidad de Libros: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(33, 332);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 19);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(131, 148);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(45, 19);
            this.lblNombreC.TabIndex = 8;
            this.lblNombreC.Text = "label4";
            this.lblNombreC.Visible = false;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.Location = new System.Drawing.Point(131, 129);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(63, 19);
            this.lblNombreP.TabIndex = 9;
            this.lblNombreP.Text = "Nombre:";
            // 
            // btnIngresarP
            // 
            this.btnIngresarP.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarP.Location = new System.Drawing.Point(45, 389);
            this.btnIngresarP.Name = "btnIngresarP";
            this.btnIngresarP.Size = new System.Drawing.Size(75, 33);
            this.btnIngresarP.TabIndex = 10;
            this.btnIngresarP.Text = "Ingresar";
            this.btnIngresarP.UseVisualStyleBackColor = true;
            this.btnIngresarP.Click += new System.EventHandler(this.btnIngresarP_Click);
            // 
            // btnVolverP
            // 
            this.btnVolverP.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverP.Location = new System.Drawing.Point(333, 389);
            this.btnVolverP.Name = "btnVolverP";
            this.btnVolverP.Size = new System.Drawing.Size(75, 33);
            this.btnVolverP.TabIndex = 11;
            this.btnVolverP.Text = "Volver";
            this.btnVolverP.UseVisualStyleBackColor = true;
            this.btnVolverP.Click += new System.EventHandler(this.btnVolverP_Click);
            // 
            // nudwCantidad
            // 
            this.nudwCantidad.Location = new System.Drawing.Point(170, 278);
            this.nudwCantidad.Name = "nudwCantidad";
            this.nudwCantidad.Size = new System.Drawing.Size(61, 20);
            this.nudwCantidad.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(442, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(440, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 33);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPedido.Location = new System.Drawing.Point(534, 54);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(100, 25);
            this.txtCodPedido.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigo Pedido:";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(142, 217);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(43, 19);
            this.lblLibro.TabIndex = 18;
            this.lblLibro.Text = "Libro:";
            // 
            // lblNombreLib
            // 
            this.lblNombreLib.AutoSize = true;
            this.lblNombreLib.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLib.Location = new System.Drawing.Point(140, 236);
            this.lblNombreLib.Name = "lblNombreLib";
            this.lblNombreLib.Size = new System.Drawing.Size(45, 19);
            this.lblNombreLib.TabIndex = 17;
            this.lblNombreLib.Text = "label4";
            this.lblNombreLib.Visible = false;
            // 
            // lblIDLibro
            // 
            this.lblIDLibro.AutoSize = true;
            this.lblIDLibro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLibro.Location = new System.Drawing.Point(33, 187);
            this.lblIDLibro.Name = "lblIDLibro";
            this.lblIDLibro.Size = new System.Drawing.Size(61, 19);
            this.lblIDLibro.TabIndex = 20;
            this.lblIDLibro.Text = "ID Libro:";
            // 
            // cbbxIDLibro
            // 
            this.cbbxIDLibro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxIDLibro.FormattingEnabled = true;
            this.cbbxIDLibro.Location = new System.Drawing.Point(100, 184);
            this.cbbxIDLibro.Name = "cbbxIDLibro";
            this.cbbxIDLibro.Size = new System.Drawing.Size(121, 27);
            this.cbbxIDLibro.TabIndex = 19;
            this.cbbxIDLibro.SelectedIndexChanged += new System.EventHandler(this.cbbxIDLibro_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 228);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnBuscarPed
            // 
            this.btnBuscarPed.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPed.Location = new System.Drawing.Point(666, 50);
            this.btnBuscarPed.Name = "btnBuscarPed";
            this.btnBuscarPed.Size = new System.Drawing.Size(75, 33);
            this.btnBuscarPed.TabIndex = 22;
            this.btnBuscarPed.Text = "Buscar";
            this.btnBuscarPed.UseVisualStyleBackColor = true;
            this.btnBuscarPed.Click += new System.EventHandler(this.btnBuscarPed_Click);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 474);
            this.Controls.Add(this.btnBuscarPed);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblIDLibro);
            this.Controls.Add(this.cbbxIDLibro);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblNombreLib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodPedido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.nudwCantidad);
            this.Controls.Add(this.btnVolverP);
            this.Controls.Add(this.btnIngresarP);
            this.Controls.Add(this.lblNombreP);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCantLib);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.dtmpFecha);
            this.Controls.Add(this.cbbxIDClie);
            this.Controls.Add(this.lblEtiquetaPed);
            this.Controls.Add(this.btnLimpiarP);
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudwCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarP;
        private System.Windows.Forms.Label lblEtiquetaPed;
        private System.Windows.Forms.ComboBox cbbxIDClie;
        private System.Windows.Forms.DateTimePicker dtmpFecha;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblCantLib;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Button btnIngresarP;
        private System.Windows.Forms.Button btnVolverP;
        private System.Windows.Forms.NumericUpDown nudwCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblNombreLib;
        private System.Windows.Forms.Label lblIDLibro;
        private System.Windows.Forms.ComboBox cbbxIDLibro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscarPed;
    }
}