namespace Proyecto_final 
{
    partial class CambiarEstatus
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
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.cbbxProducto = new System.Windows.Forms.ComboBox();
            this.rdbActivar = new System.Windows.Forms.RadioButton();
            this.rdbDesactivar = new System.Windows.Forms.RadioButton();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblBuscPro = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProducto
            // 
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Location = new System.Drawing.Point(60, 215);
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.Size = new System.Drawing.Size(544, 209);
            this.dtgProducto.TabIndex = 0;
            // 
            // cbbxProducto
            // 
            this.cbbxProducto.FormattingEnabled = true;
            this.cbbxProducto.Location = new System.Drawing.Point(106, 86);
            this.cbbxProducto.Name = "cbbxProducto";
            this.cbbxProducto.Size = new System.Drawing.Size(121, 21);
            this.cbbxProducto.TabIndex = 1;
            // 
            // rdbActivar
            // 
            this.rdbActivar.AutoSize = true;
            this.rdbActivar.Location = new System.Drawing.Point(280, 87);
            this.rdbActivar.Name = "rdbActivar";
            this.rdbActivar.Size = new System.Drawing.Size(58, 17);
            this.rdbActivar.TabIndex = 2;
            this.rdbActivar.TabStop = true;
            this.rdbActivar.Text = "Activar";
            this.rdbActivar.UseVisualStyleBackColor = true;
            // 
            // rdbDesactivar
            // 
            this.rdbDesactivar.AutoSize = true;
            this.rdbDesactivar.Location = new System.Drawing.Point(371, 87);
            this.rdbDesactivar.Name = "rdbDesactivar";
            this.rdbDesactivar.Size = new System.Drawing.Size(76, 17);
            this.rdbDesactivar.TabIndex = 3;
            this.rdbDesactivar.TabStop = true;
            this.rdbDesactivar.Text = "Desactivar";
            this.rdbDesactivar.UseVisualStyleBackColor = true;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(47, 89);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto:";
            // 
            // lblBuscPro
            // 
            this.lblBuscPro.AutoSize = true;
            this.lblBuscPro.Location = new System.Drawing.Point(347, 161);
            this.lblBuscPro.Name = "lblBuscPro";
            this.lblBuscPro.Size = new System.Drawing.Size(47, 13);
            this.lblBuscPro.TabIndex = 5;
            this.lblBuscPro.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(529, 156);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(400, 158);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(485, 84);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // CambiarEstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscPro);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.rdbDesactivar);
            this.Controls.Add(this.rdbActivar);
            this.Controls.Add(this.cbbxProducto);
            this.Controls.Add(this.dtgProducto);
            this.Name = "CambiarEstatus";
            this.Text = "Cambiar el estatus";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.ComboBox cbbxProducto;
        private System.Windows.Forms.RadioButton rdbActivar;
        private System.Windows.Forms.RadioButton rdbDesactivar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblBuscPro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnModificar;
    }
}