namespace Proyecto_final 
{
    partial class Articulos9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecioventa = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.lblestatus = new System.Windows.Forms.Label();
            this.cbbxestatus = new System.Windows.Forms.ComboBox();
            this.lbletiqueta = new System.Windows.Forms.Label();
            this.btnIrHistorial = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(96, 116);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(47, 119);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "Codigo:";
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(234, 379);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(72, 36);
            this.btningresar.TabIndex = 3;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(43, 174);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(96, 171);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(50, 228);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(40, 13);
            this.lblprecio.TabIndex = 7;
            this.lblprecio.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(96, 225);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 6;
            // 
            // lblprecioventa
            // 
            this.lblprecioventa.AutoSize = true;
            this.lblprecioventa.Location = new System.Drawing.Point(19, 284);
            this.lblprecioventa.Name = "lblprecioventa";
            this.lblprecioventa.Size = new System.Drawing.Size(71, 13);
            this.lblprecioventa.TabIndex = 9;
            this.lblprecioventa.Text = "Precio Venta:";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(96, 281);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(100, 20);
            this.txtprecioventa.TabIndex = 8;
            // 
            // lblestatus
            // 
            this.lblestatus.AutoSize = true;
            this.lblestatus.Location = new System.Drawing.Point(45, 339);
            this.lblestatus.Name = "lblestatus";
            this.lblestatus.Size = new System.Drawing.Size(45, 13);
            this.lblestatus.TabIndex = 11;
            this.lblestatus.Text = "Estatus:";
            // 
            // cbbxestatus
            // 
            this.cbbxestatus.FormattingEnabled = true;
            this.cbbxestatus.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cbbxestatus.Location = new System.Drawing.Point(96, 336);
            this.cbbxestatus.Name = "cbbxestatus";
            this.cbbxestatus.Size = new System.Drawing.Size(59, 21);
            this.cbbxestatus.TabIndex = 12;
            // 
            // lbletiqueta
            // 
            this.lbletiqueta.AutoSize = true;
            this.lbletiqueta.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletiqueta.Location = new System.Drawing.Point(248, 25);
            this.lbletiqueta.Name = "lbletiqueta";
            this.lbletiqueta.Size = new System.Drawing.Size(200, 28);
            this.lbletiqueta.TabIndex = 13;
            this.lbletiqueta.Text = "Ingresar Articulos";
            // 
            // btnIrHistorial
            // 
            this.btnIrHistorial.Location = new System.Drawing.Point(660, 379);
            this.btnIrHistorial.Name = "btnIrHistorial";
            this.btnIrHistorial.Size = new System.Drawing.Size(71, 36);
            this.btnIrHistorial.TabIndex = 14;
            this.btnIrHistorial.Text = "Ir a Historial";
            this.btnIrHistorial.UseVisualStyleBackColor = true;
            this.btnIrHistorial.Click += new System.EventHandler(this.btnIrHistorial_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(659, 24);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 36);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Articulos9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 453);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIrHistorial);
            this.Controls.Add(this.lbletiqueta);
            this.Controls.Add(this.cbbxestatus);
            this.Controls.Add(this.lblestatus);
            this.Controls.Add(this.lblprecioventa);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Articulos9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecioventa;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label lblestatus;
        private System.Windows.Forms.ComboBox cbbxestatus;
        private System.Windows.Forms.Label lbletiqueta;
        private System.Windows.Forms.Button btnIrHistorial;
        private System.Windows.Forms.Button btnCerrar;
    }
}

