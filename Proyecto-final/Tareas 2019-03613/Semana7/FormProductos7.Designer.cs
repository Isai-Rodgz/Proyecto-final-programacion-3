namespace Proyecto_final 
{
    partial class FormProductos7
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
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombreprod = new System.Windows.Forms.TextBox();
            this.lblNombProd = new System.Windows.Forms.Label();
            this.txtIdprod = new System.Windows.Forms.TextBox();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lbl_idprod = new System.Windows.Forms.Label();
            this.txtpreciov = new System.Windows.Forms.TextBox();
            this.lblpreciov = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarNom = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnIrPedidos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(52, 237);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(40, 13);
            this.lblprecio.TabIndex = 0;
            this.lblprecio.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(98, 234);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(165, 378);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombreprod
            // 
            this.txtNombreprod.Location = new System.Drawing.Point(98, 191);
            this.txtNombreprod.Name = "txtNombreprod";
            this.txtNombreprod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreprod.TabIndex = 2;
            // 
            // lblNombProd
            // 
            this.lblNombProd.AutoSize = true;
            this.lblNombProd.Location = new System.Drawing.Point(45, 194);
            this.lblNombProd.Name = "lblNombProd";
            this.lblNombProd.Size = new System.Drawing.Size(47, 13);
            this.lblNombProd.TabIndex = 3;
            this.lblNombProd.Text = "Nombre:";
            // 
            // txtIdprod
            // 
            this.txtIdprod.Location = new System.Drawing.Point(98, 147);
            this.txtIdprod.Name = "txtIdprod";
            this.txtIdprod.Size = new System.Drawing.Size(100, 20);
            this.txtIdprod.TabIndex = 1;
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.Location = new System.Drawing.Point(34, 324);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(58, 13);
            this.lblexistencia.TabIndex = 5;
            this.lblexistencia.Text = "Existencia:";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(98, 321);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtExistencia.TabIndex = 5;
            // 
            // lbl_idprod
            // 
            this.lbl_idprod.AutoSize = true;
            this.lbl_idprod.Location = new System.Drawing.Point(25, 150);
            this.lbl_idprod.Name = "lbl_idprod";
            this.lbl_idprod.Size = new System.Drawing.Size(67, 13);
            this.lbl_idprod.TabIndex = 7;
            this.lbl_idprod.Text = "ID Producto:";
            // 
            // txtpreciov
            // 
            this.txtpreciov.Location = new System.Drawing.Point(98, 278);
            this.txtpreciov.Name = "txtpreciov";
            this.txtpreciov.Size = new System.Drawing.Size(100, 20);
            this.txtpreciov.TabIndex = 4;
            // 
            // lblpreciov
            // 
            this.lblpreciov.AutoSize = true;
            this.lblpreciov.Location = new System.Drawing.Point(21, 281);
            this.lblpreciov.Name = "lblpreciov";
            this.lblpreciov.Size = new System.Drawing.Size(71, 13);
            this.lblpreciov.TabIndex = 9;
            this.lblpreciov.Text = "Precio Venta:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(55, 378);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(667, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarNom
            // 
            this.lblBuscarNom.AutoSize = true;
            this.lblBuscarNom.Location = new System.Drawing.Point(440, 111);
            this.lblBuscarNom.Name = "lblBuscarNom";
            this.lblBuscarNom.Size = new System.Drawing.Size(47, 13);
            this.lblBuscarNom.TabIndex = 14;
            this.lblBuscarNom.Text = "Nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(493, 108);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(153, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 235);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(327, 34);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(121, 28);
            this.lblProductos.TabIndex = 16;
            this.lblProductos.Text = "Productos";
            // 
            // btnIrPedidos
            // 
            this.btnIrPedidos.Location = new System.Drawing.Point(693, 404);
            this.btnIrPedidos.Name = "btnIrPedidos";
            this.btnIrPedidos.Size = new System.Drawing.Size(75, 34);
            this.btnIrPedidos.TabIndex = 10;
            this.btnIrPedidos.Text = "Ir a Pedidos";
            this.btnIrPedidos.UseVisualStyleBackColor = true;
            this.btnIrPedidos.Click += new System.EventHandler(this.btnIrPedidos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(693, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 34);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 465);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIrPedidos);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBuscarNom);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtpreciov);
            this.Controls.Add(this.lblpreciov);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lbl_idprod);
            this.Controls.Add(this.txtIdprod);
            this.Controls.Add(this.lblexistencia);
            this.Controls.Add(this.txtNombreprod);
            this.Controls.Add(this.lblNombProd);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblprecio);
            this.Name = "FormProductos";
            this.Text = "Ventana de Productos";
            this.Load += new System.EventHandler(this.FomProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombreprod;
        private System.Windows.Forms.Label lblNombProd;
        private System.Windows.Forms.TextBox txtIdprod;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label lbl_idprod;
        private System.Windows.Forms.TextBox txtpreciov;
        private System.Windows.Forms.Label lblpreciov;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarNom;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnIrPedidos;
        private System.Windows.Forms.Button btnCerrar;
    }
}

