namespace Proyecto_final
{
    partial class MenuPrinc6
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
            this.btnReg_Prod = new System.Windows.Forms.Button();
            this.btnReg_Clien = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblEtiquetaPrinc = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReg_Prod
            // 
            this.btnReg_Prod.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg_Prod.Location = new System.Drawing.Point(291, 147);
            this.btnReg_Prod.Name = "btnReg_Prod";
            this.btnReg_Prod.Size = new System.Drawing.Size(190, 114);
            this.btnReg_Prod.TabIndex = 0;
            this.btnReg_Prod.Text = "Registrar Productos";
            this.btnReg_Prod.UseVisualStyleBackColor = true;
            this.btnReg_Prod.Click += new System.EventHandler(this.btnReg_Prod_Click);
            // 
            // btnReg_Clien
            // 
            this.btnReg_Clien.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg_Clien.Location = new System.Drawing.Point(536, 147);
            this.btnReg_Clien.Name = "btnReg_Clien";
            this.btnReg_Clien.Size = new System.Drawing.Size(190, 114);
            this.btnReg_Clien.TabIndex = 1;
            this.btnReg_Clien.Text = "Registrar Clientes";
            this.btnReg_Clien.UseVisualStyleBackColor = true;
            this.btnReg_Clien.Click += new System.EventHandler(this.btnReg_Clien_Click);
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(55, 147);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(190, 114);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Ir a Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lblEtiquetaPrinc
            // 
            this.lblEtiquetaPrinc.AutoSize = true;
            this.lblEtiquetaPrinc.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaPrinc.Location = new System.Drawing.Point(284, 50);
            this.lblEtiquetaPrinc.Name = "lblEtiquetaPrinc";
            this.lblEtiquetaPrinc.Size = new System.Drawing.Size(204, 38);
            this.lblEtiquetaPrinc.TabIndex = 3;
            this.lblEtiquetaPrinc.Text = "¿A donde va?";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(311, 299);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(156, 27);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 350);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblEtiquetaPrinc);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnReg_Clien);
            this.Controls.Add(this.btnReg_Prod);
            this.Name = "MenuPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg_Prod;
        private System.Windows.Forms.Button btnReg_Clien;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblEtiquetaPrinc;
        private System.Windows.Forms.Button btnCerrar;
    }
}