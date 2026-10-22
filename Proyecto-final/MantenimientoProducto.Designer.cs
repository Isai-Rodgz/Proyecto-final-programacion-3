namespace Proyecto_final
{
    partial class MantenimientoProducto
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
            this.lblProd_ID = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescri = new System.Windows.Forms.Label();
            this.txtIdPro = new MyLibreria.ErrorTextBox();
            this.txtNomPro = new MyLibreria.ErrorTextBox();
            this.txtPrecio = new MyLibreria.ErrorTextBox();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.lblestatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(411, 53);
            this.btnConsultar.Size = new System.Drawing.Size(132, 33);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 128);
            this.button2.Size = new System.Drawing.Size(132, 33);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(411, 203);
            this.button3.Size = new System.Drawing.Size(132, 33);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 279);
            this.button4.Size = new System.Drawing.Size(132, 33);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(411, 351);
            this.BtnSalir.Size = new System.Drawing.Size(132, 33);
            // 
            // lblProd_ID
            // 
            this.lblProd_ID.AutoSize = true;
            this.lblProd_ID.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd_ID.Location = new System.Drawing.Point(32, 85);
            this.lblProd_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProd_ID.Name = "lblProd_ID";
            this.lblProd_ID.Size = new System.Drawing.Size(87, 25);
            this.lblProd_ID.TabIndex = 4;
            this.lblProd_ID.Text = "ID Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(35, 298);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 25);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescri.Location = new System.Drawing.Point(32, 195);
            this.lblDescri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(86, 25);
            this.lblDescri.TabIndex = 8;
            this.lblDescri.Text = "Descripcion:";
            // 
            // txtIdPro
            // 
            this.txtIdPro.Location = new System.Drawing.Point(139, 85);
            this.txtIdPro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.Size = new System.Drawing.Size(121, 25);
            this.txtIdPro.SoloNumeros = true;
            this.txtIdPro.TabIndex = 10;
            this.txtIdPro.Validar = true;
            this.txtIdPro.TextChanged += new System.EventHandler(this.txtIdPro_TextChanged);
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(139, 198);
            this.txtNomPro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Size = new System.Drawing.Size(121, 25);
            this.txtNomPro.SoloNumeros = false;
            this.txtNomPro.TabIndex = 11;
            this.txtNomPro.Validar = true;
            this.txtNomPro.TextChanged += new System.EventHandler(this.txtNomPro_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(139, 301);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 25);
            this.txtPrecio.SoloNumeros = true;
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.Validar = true;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(180, 372);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(59, 22);
            this.rdbInactivo.TabIndex = 24;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(110, 372);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(53, 22);
            this.rdbActivo.TabIndex = 23;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // lblestatus
            // 
            this.lblestatus.AutoSize = true;
            this.lblestatus.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestatus.Location = new System.Drawing.Point(31, 368);
            this.lblestatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblestatus.Name = "lblestatus";
            this.lblestatus.Size = new System.Drawing.Size(59, 25);
            this.lblestatus.TabIndex = 22;
            this.lblestatus.Text = "Estatus:";
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 430);
            this.Controls.Add(this.rdbInactivo);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.lblestatus);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNomPro);
            this.Controls.Add(this.txtIdPro);
            this.Controls.Add(this.lblDescri);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblProd_ID);
            this.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.Name = "MantenimientoProducto";
            this.Text = "MantenimientoProducto";
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.lblProd_ID, 0);
            this.Controls.SetChildIndex(this.lblPrecio, 0);
            this.Controls.SetChildIndex(this.lblDescri, 0);
            this.Controls.SetChildIndex(this.txtIdPro, 0);
            this.Controls.SetChildIndex(this.txtNomPro, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.lblestatus, 0);
            this.Controls.SetChildIndex(this.rdbActivo, 0);
            this.Controls.SetChildIndex(this.rdbInactivo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProd_ID;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescri;
        private MyLibreria.ErrorTextBox txtIdPro;
        private MyLibreria.ErrorTextBox txtNomPro;
        private MyLibreria.ErrorTextBox txtPrecio;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.Label lblestatus;
    }
}