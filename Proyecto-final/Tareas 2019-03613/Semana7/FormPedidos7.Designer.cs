namespace Proyecto_final 
{
    partial class FormPedidos7
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnIrProducto = new System.Windows.Forms.Button();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBuscPedido = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbl_idpedido = new System.Windows.Forms.Label();
            this.txtIdpedido = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.lbl_IdProd = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(699, 20);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 34);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIrProducto
            // 
            this.btnIrProducto.Location = new System.Drawing.Point(699, 396);
            this.btnIrProducto.Name = "btnIrProducto";
            this.btnIrProducto.Size = new System.Drawing.Size(75, 42);
            this.btnIrProducto.TabIndex = 7;
            this.btnIrProducto.Text = "Ir a Productos";
            this.btnIrProducto.UseVisualStyleBackColor = true;
            this.btnIrProducto.Click += new System.EventHandler(this.btnIrProducto_Click);
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(333, 26);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(96, 28);
            this.lblPedidos.TabIndex = 35;
            this.lblPedidos.Text = "Pedidos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 235);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblBuscPedido
            // 
            this.lblBuscPedido.AutoSize = true;
            this.lblBuscPedido.Location = new System.Drawing.Point(501, 103);
            this.lblBuscPedido.Name = "lblBuscPedido";
            this.lblBuscPedido.Size = new System.Drawing.Size(63, 13);
            this.lblBuscPedido.TabIndex = 33;
            this.lblBuscPedido.Text = "No. Pedido:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(570, 100);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(72, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(673, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(55, 351);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbl_idpedido
            // 
            this.lbl_idpedido.AutoSize = true;
            this.lbl_idpedido.Location = new System.Drawing.Point(39, 163);
            this.lbl_idpedido.Name = "lbl_idpedido";
            this.lbl_idpedido.Size = new System.Drawing.Size(57, 13);
            this.lbl_idpedido.TabIndex = 26;
            this.lbl_idpedido.Text = "ID Pedido:";
            // 
            // txtIdpedido
            // 
            this.txtIdpedido.Location = new System.Drawing.Point(102, 160);
            this.txtIdpedido.Name = "txtIdpedido";
            this.txtIdpedido.ReadOnly = true;
            this.txtIdpedido.Size = new System.Drawing.Size(100, 20);
            this.txtIdpedido.TabIndex = 10;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(102, 218);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(100, 20);
            this.txtIdProd.TabIndex = 1;
            // 
            // lbl_IdProd
            // 
            this.lbl_IdProd.AutoSize = true;
            this.lbl_IdProd.Location = new System.Drawing.Point(29, 221);
            this.lbl_IdProd.Name = "lbl_IdProd";
            this.lbl_IdProd.Size = new System.Drawing.Size(67, 13);
            this.lbl_IdProd.TabIndex = 22;
            this.lbl_IdProd.Text = "ID Producto:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(165, 351);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(102, 275);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(44, 278);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // FormPedidos7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIrProducto);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBuscPedido);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbl_idpedido);
            this.Controls.Add(this.txtIdpedido);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.lbl_IdProd);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Name = "FormPedidos7";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnIrProducto;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBuscPedido;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbl_idpedido;
        private System.Windows.Forms.TextBox txtIdpedido;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Label lbl_IdProd;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}