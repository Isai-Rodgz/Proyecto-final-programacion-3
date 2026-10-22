namespace Proyecto_final
{
    partial class Facturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.BtnColocar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCodigoCli = new MyLibreria.ErrorTextBox();
            this.TxtCliente = new MyLibreria.ErrorTextBox();
            this.TxtCodigoPro = new MyLibreria.ErrorTextBox();
            this.TxtDescripcion = new MyLibreria.ErrorTextBox();
            this.TxtCantidad = new MyLibreria.ErrorTextBox();
            this.TxtPrecio = new MyLibreria.ErrorTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.LblAtiende = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(686, 469);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.BtnSalir.Size = new System.Drawing.Size(120, 30);
            // 
            // BtnColocar
            // 
            this.BtnColocar.Location = new System.Drawing.Point(686, 163);
            this.BtnColocar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtnColocar.Name = "BtnColocar";
            this.BtnColocar.Size = new System.Drawing.Size(120, 30);
            this.BtnColocar.TabIndex = 1;
            this.BtnColocar.Text = "Colocar";
            this.BtnColocar.UseVisualStyleBackColor = true;
            this.BtnColocar.Click += new System.EventHandler(this.BtnColocar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(686, 212);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 30);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(686, 262);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(120, 30);
            this.BtnClientes.TabIndex = 3;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Location = new System.Drawing.Point(686, 313);
            this.BtnProductos.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(120, 30);
            this.BtnProductos.TabIndex = 4;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(686, 366);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(120, 30);
            this.BtnNuevo.TabIndex = 5;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Location = new System.Drawing.Point(686, 422);
            this.BtnFacturar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(120, 30);
            this.BtnFacturar.TabIndex = 6;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Le atiende:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(131, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(302, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(426, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(555, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Importe";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCodigo,
            this.CodDescripcion,
            this.CodPrecio,
            this.CodCantidad,
            this.CodImporte});
            this.dataGridView1.Location = new System.Drawing.Point(10, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(626, 363);
            this.dataGridView1.TabIndex = 15;
            // 
            // CodCodigo
            // 
            this.CodCodigo.HeaderText = "Codigo";
            this.CodCodigo.Name = "CodCodigo";
            this.CodCodigo.ReadOnly = true;
            this.CodCodigo.Width = 110;
            // 
            // CodDescripcion
            // 
            this.CodDescripcion.HeaderText = "Descripcion";
            this.CodDescripcion.Name = "CodDescripcion";
            this.CodDescripcion.ReadOnly = true;
            this.CodDescripcion.Width = 200;
            // 
            // CodPrecio
            // 
            this.CodPrecio.HeaderText = "Precio";
            this.CodPrecio.Name = "CodPrecio";
            this.CodPrecio.ReadOnly = true;
            this.CodPrecio.Width = 110;
            // 
            // CodCantidad
            // 
            this.CodCantidad.HeaderText = "Cantidad";
            this.CodCantidad.Name = "CodCantidad";
            this.CodCantidad.ReadOnly = true;
            this.CodCantidad.Width = 110;
            // 
            // CodImporte
            // 
            this.CodImporte.HeaderText = "Importe";
            this.CodImporte.Name = "CodImporte";
            this.CodImporte.ReadOnly = true;
            this.CodImporte.Width = 110;
            // 
            // TxtCodigoCli
            // 
            this.TxtCodigoCli.Location = new System.Drawing.Point(87, 58);
            this.TxtCodigoCli.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtCodigoCli.Name = "TxtCodigoCli";
            this.TxtCodigoCli.Size = new System.Drawing.Size(101, 25);
            this.TxtCodigoCli.SoloNumeros = false;
            this.TxtCodigoCli.TabIndex = 17;
            this.TxtCodigoCli.Validar = true;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(87, 94);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(218, 25);
            this.TxtCliente.SoloNumeros = false;
            this.TxtCliente.TabIndex = 18;
            this.TxtCliente.Validar = true;
            // 
            // TxtCodigoPro
            // 
            this.TxtCodigoPro.Location = new System.Drawing.Point(10, 134);
            this.TxtCodigoPro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtCodigoPro.Name = "TxtCodigoPro";
            this.TxtCodigoPro.Size = new System.Drawing.Size(107, 25);
            this.TxtCodigoPro.SoloNumeros = false;
            this.TxtCodigoPro.TabIndex = 19;
            this.TxtCodigoPro.Validar = true;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(134, 134);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(171, 25);
            this.TxtDescripcion.SoloNumeros = false;
            this.TxtDescripcion.TabIndex = 20;
            this.TxtDescripcion.Validar = true;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(441, 134);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 25);
            this.TxtCantidad.SoloNumeros = false;
            this.TxtCantidad.TabIndex = 21;
            this.TxtCantidad.Validar = true;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(319, 134);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 25);
            this.TxtPrecio.SoloNumeros = false;
            this.TxtPrecio.TabIndex = 22;
            this.TxtPrecio.Validar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 767);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(574, 748);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 37);
            this.label10.TabIndex = 25;
            this.label10.Text = "               ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(230, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 29);
            this.button7.TabIndex = 26;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // LblAtiende
            // 
            this.LblAtiende.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblAtiende.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAtiende.Location = new System.Drawing.Point(89, 21);
            this.LblAtiende.Name = "LblAtiende";
            this.LblAtiende.Size = new System.Drawing.Size(99, 22);
            this.LblAtiende.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(641, 532);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 32);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total:";
            // 
            // LblTotal
            // 
            this.LblTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotal.Location = new System.Drawing.Point(694, 532);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(112, 32);
            this.LblTotal.TabIndex = 29;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(654, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(817, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblAtiende);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigoPro);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtCodigoCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnColocar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            this.Controls.SetChildIndex(this.BtnColocar, 0);
            this.Controls.SetChildIndex(this.BtnEliminar, 0);
            this.Controls.SetChildIndex(this.BtnClientes, 0);
            this.Controls.SetChildIndex(this.BtnProductos, 0);
            this.Controls.SetChildIndex(this.BtnNuevo, 0);
            this.Controls.SetChildIndex(this.BtnFacturar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtCodigoCli, 0);
            this.Controls.SetChildIndex(this.TxtCliente, 0);
            this.Controls.SetChildIndex(this.TxtCodigoPro, 0);
            this.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.Controls.SetChildIndex(this.TxtCantidad, 0);
            this.Controls.SetChildIndex(this.TxtPrecio, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.LblAtiende, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.LblTotal, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnColocar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyLibreria.ErrorTextBox TxtCodigoCli;
        private MyLibreria.ErrorTextBox TxtCliente;
        private MyLibreria.ErrorTextBox TxtCodigoPro;
        private MyLibreria.ErrorTextBox TxtDescripcion;
        private MyLibreria.ErrorTextBox TxtCantidad;
        private MyLibreria.ErrorTextBox TxtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label LblAtiende;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodImporte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}