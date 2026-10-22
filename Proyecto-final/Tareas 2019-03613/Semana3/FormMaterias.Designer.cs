namespace Proyecto_final 
{
    partial class FormMaterias
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
            this.txtbusc_Mate = new System.Windows.Forms.TextBox();
            this.lblbusc_Mate = new System.Windows.Forms.Label();
            this.gbxReg_Mate = new System.Windows.Forms.GroupBox();
            this.btnElim_Mat = new System.Windows.Forms.Button();
            this.dtgv_Mate = new System.Windows.Forms.DataGridView();
            this.btnModif_Mat = new System.Windows.Forms.Button();
            this.btnBusc_Mat_Re = new System.Windows.Forms.Button();
            this.gbxMaterias2 = new System.Windows.Forms.GroupBox();
            this.btnInsertar_Mat = new System.Windows.Forms.Button();
            this.txtUV_In = new System.Windows.Forms.TextBox();
            this.lblPrerequi_In = new System.Windows.Forms.Label();
            this.txtPrerequi_In = new System.Windows.Forms.TextBox();
            this.lblUV_In = new System.Windows.Forms.Label();
            this.lblCod_Mate_In = new System.Windows.Forms.Label();
            this.txtNomb_Mate_In = new System.Windows.Forms.TextBox();
            this.txtCod_Mate_In = new System.Windows.Forms.TextBox();
            this.lblNomb_Mate_In = new System.Windows.Forms.Label();
            this.btnVolver_Mat = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxReg_Mate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Mate)).BeginInit();
            this.gbxMaterias2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbusc_Mate
            // 
            this.txtbusc_Mate.Location = new System.Drawing.Point(244, 28);
            this.txtbusc_Mate.Name = "txtbusc_Mate";
            this.txtbusc_Mate.Size = new System.Drawing.Size(94, 20);
            this.txtbusc_Mate.TabIndex = 5;
            // 
            // lblbusc_Mate
            // 
            this.lblbusc_Mate.AutoSize = true;
            this.lblbusc_Mate.Location = new System.Drawing.Point(195, 31);
            this.lblbusc_Mate.Name = "lblbusc_Mate";
            this.lblbusc_Mate.Size = new System.Drawing.Size(47, 13);
            this.lblbusc_Mate.TabIndex = 16;
            this.lblbusc_Mate.Text = "Nombre:";
            // 
            // gbxReg_Mate
            // 
            this.gbxReg_Mate.Controls.Add(this.btnElim_Mat);
            this.gbxReg_Mate.Controls.Add(this.dtgv_Mate);
            this.gbxReg_Mate.Controls.Add(this.lblbusc_Mate);
            this.gbxReg_Mate.Controls.Add(this.btnModif_Mat);
            this.gbxReg_Mate.Controls.Add(this.txtbusc_Mate);
            this.gbxReg_Mate.Controls.Add(this.btnBusc_Mat_Re);
            this.gbxReg_Mate.Location = new System.Drawing.Point(441, 66);
            this.gbxReg_Mate.Name = "gbxReg_Mate";
            this.gbxReg_Mate.Size = new System.Drawing.Size(491, 291);
            this.gbxReg_Mate.TabIndex = 23;
            this.gbxReg_Mate.TabStop = false;
            this.gbxReg_Mate.Text = "Registro de Materias";
            // 
            // btnElim_Mat
            // 
            this.btnElim_Mat.Location = new System.Drawing.Point(361, 239);
            this.btnElim_Mat.Name = "btnElim_Mat";
            this.btnElim_Mat.Size = new System.Drawing.Size(75, 30);
            this.btnElim_Mat.TabIndex = 24;
            this.btnElim_Mat.Text = "Eliminar";
            this.btnElim_Mat.UseVisualStyleBackColor = true;
            this.btnElim_Mat.Click += new System.EventHandler(this.btnElim_Mat_Click);
            // 
            // dtgv_Mate
            // 
            this.dtgv_Mate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Mate.Location = new System.Drawing.Point(42, 65);
            this.dtgv_Mate.Name = "dtgv_Mate";
            this.dtgv_Mate.Size = new System.Drawing.Size(394, 159);
            this.dtgv_Mate.TabIndex = 18;
            // 
            // btnModif_Mat
            // 
            this.btnModif_Mat.Location = new System.Drawing.Point(244, 239);
            this.btnModif_Mat.Name = "btnModif_Mat";
            this.btnModif_Mat.Size = new System.Drawing.Size(75, 30);
            this.btnModif_Mat.TabIndex = 23;
            this.btnModif_Mat.Text = "Modificar";
            this.btnModif_Mat.UseVisualStyleBackColor = true;
            this.btnModif_Mat.Click += new System.EventHandler(this.btnModif_Mat_Click);
            // 
            // btnBusc_Mat_Re
            // 
            this.btnBusc_Mat_Re.Location = new System.Drawing.Point(361, 22);
            this.btnBusc_Mat_Re.Name = "btnBusc_Mat_Re";
            this.btnBusc_Mat_Re.Size = new System.Drawing.Size(75, 30);
            this.btnBusc_Mat_Re.TabIndex = 22;
            this.btnBusc_Mat_Re.Text = "Buscar";
            this.btnBusc_Mat_Re.UseVisualStyleBackColor = true;
            this.btnBusc_Mat_Re.Click += new System.EventHandler(this.btnBusc_Mat_Re_Click);
            // 
            // gbxMaterias2
            // 
            this.gbxMaterias2.Controls.Add(this.btnInsertar_Mat);
            this.gbxMaterias2.Controls.Add(this.txtUV_In);
            this.gbxMaterias2.Controls.Add(this.lblPrerequi_In);
            this.gbxMaterias2.Controls.Add(this.txtPrerequi_In);
            this.gbxMaterias2.Controls.Add(this.lblUV_In);
            this.gbxMaterias2.Controls.Add(this.lblCod_Mate_In);
            this.gbxMaterias2.Controls.Add(this.txtNomb_Mate_In);
            this.gbxMaterias2.Controls.Add(this.txtCod_Mate_In);
            this.gbxMaterias2.Controls.Add(this.lblNomb_Mate_In);
            this.gbxMaterias2.Location = new System.Drawing.Point(28, 66);
            this.gbxMaterias2.Name = "gbxMaterias2";
            this.gbxMaterias2.Size = new System.Drawing.Size(365, 286);
            this.gbxMaterias2.TabIndex = 26;
            this.gbxMaterias2.TabStop = false;
            this.gbxMaterias2.Text = "Materias";
            // 
            // btnInsertar_Mat
            // 
            this.btnInsertar_Mat.Location = new System.Drawing.Point(244, 239);
            this.btnInsertar_Mat.Name = "btnInsertar_Mat";
            this.btnInsertar_Mat.Size = new System.Drawing.Size(75, 30);
            this.btnInsertar_Mat.TabIndex = 23;
            this.btnInsertar_Mat.Text = "Insertar";
            this.btnInsertar_Mat.UseVisualStyleBackColor = true;
            this.btnInsertar_Mat.Click += new System.EventHandler(this.btnInsertar_Mat_Click);
            // 
            // txtUV_In
            // 
            this.txtUV_In.Location = new System.Drawing.Point(107, 103);
            this.txtUV_In.Name = "txtUV_In";
            this.txtUV_In.Size = new System.Drawing.Size(62, 20);
            this.txtUV_In.TabIndex = 3;
            // 
            // lblPrerequi_In
            // 
            this.lblPrerequi_In.AutoSize = true;
            this.lblPrerequi_In.Location = new System.Drawing.Point(23, 143);
            this.lblPrerequi_In.Name = "lblPrerequi_In";
            this.lblPrerequi_In.Size = new System.Drawing.Size(78, 13);
            this.lblPrerequi_In.TabIndex = 12;
            this.lblPrerequi_In.Text = "Pre-Requisitos:";
            // 
            // txtPrerequi_In
            // 
            this.txtPrerequi_In.Location = new System.Drawing.Point(107, 140);
            this.txtPrerequi_In.Multiline = true;
            this.txtPrerequi_In.Name = "txtPrerequi_In";
            this.txtPrerequi_In.Size = new System.Drawing.Size(117, 67);
            this.txtPrerequi_In.TabIndex = 4;
            // 
            // lblUV_In
            // 
            this.lblUV_In.AutoSize = true;
            this.lblUV_In.Location = new System.Drawing.Point(76, 106);
            this.lblUV_In.Name = "lblUV_In";
            this.lblUV_In.Size = new System.Drawing.Size(25, 13);
            this.lblUV_In.TabIndex = 20;
            this.lblUV_In.Text = "UV:";
            // 
            // lblCod_Mate_In
            // 
            this.lblCod_Mate_In.AutoSize = true;
            this.lblCod_Mate_In.Location = new System.Drawing.Point(58, 31);
            this.lblCod_Mate_In.Name = "lblCod_Mate_In";
            this.lblCod_Mate_In.Size = new System.Drawing.Size(43, 13);
            this.lblCod_Mate_In.TabIndex = 16;
            this.lblCod_Mate_In.Text = "Codigo:";
            // 
            // txtNomb_Mate_In
            // 
            this.txtNomb_Mate_In.Location = new System.Drawing.Point(107, 65);
            this.txtNomb_Mate_In.Name = "txtNomb_Mate_In";
            this.txtNomb_Mate_In.Size = new System.Drawing.Size(117, 20);
            this.txtNomb_Mate_In.TabIndex = 2;
            // 
            // txtCod_Mate_In
            // 
            this.txtCod_Mate_In.Location = new System.Drawing.Point(107, 28);
            this.txtCod_Mate_In.Name = "txtCod_Mate_In";
            this.txtCod_Mate_In.Size = new System.Drawing.Size(62, 20);
            this.txtCod_Mate_In.TabIndex = 1;
            // 
            // lblNomb_Mate_In
            // 
            this.lblNomb_Mate_In.AutoSize = true;
            this.lblNomb_Mate_In.Location = new System.Drawing.Point(54, 68);
            this.lblNomb_Mate_In.Name = "lblNomb_Mate_In";
            this.lblNomb_Mate_In.Size = new System.Drawing.Size(47, 13);
            this.lblNomb_Mate_In.TabIndex = 18;
            this.lblNomb_Mate_In.Text = "Nombre:";
            // 
            // btnVolver_Mat
            // 
            this.btnVolver_Mat.Location = new System.Drawing.Point(39, 12);
            this.btnVolver_Mat.Name = "btnVolver_Mat";
            this.btnVolver_Mat.Size = new System.Drawing.Size(62, 39);
            this.btnVolver_Mat.TabIndex = 28;
            this.btnVolver_Mat.Text = "Volver";
            this.btnVolver_Mat.UseVisualStyleBackColor = true;
            this.btnVolver_Mat.Click += new System.EventHandler(this.btnVolver_Mat_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(802, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 39);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 390);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver_Mat);
            this.Controls.Add(this.gbxMaterias2);
            this.Controls.Add(this.gbxReg_Mate);
            this.Name = "FormMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxReg_Mate.ResumeLayout(false);
            this.gbxReg_Mate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Mate)).EndInit();
            this.gbxMaterias2.ResumeLayout(false);
            this.gbxMaterias2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtbusc_Mate;
        private System.Windows.Forms.Label lblbusc_Mate;
        private System.Windows.Forms.GroupBox gbxReg_Mate;
        private System.Windows.Forms.Button btnElim_Mat;
        private System.Windows.Forms.Button btnModif_Mat;
        private System.Windows.Forms.Button btnBusc_Mat_Re;
        private System.Windows.Forms.DataGridView dtgv_Mate;
        private System.Windows.Forms.GroupBox gbxMaterias2;
        private System.Windows.Forms.Button btnInsertar_Mat;
        private System.Windows.Forms.TextBox txtUV_In;
        private System.Windows.Forms.Label lblPrerequi_In;
        private System.Windows.Forms.TextBox txtPrerequi_In;
        private System.Windows.Forms.Label lblUV_In;
        private System.Windows.Forms.Label lblCod_Mate_In;
        private System.Windows.Forms.TextBox txtNomb_Mate_In;
        private System.Windows.Forms.TextBox txtCod_Mate_In;
        private System.Windows.Forms.Label lblNomb_Mate_In;
        private System.Windows.Forms.Button btnVolver_Mat;
        private System.Windows.Forms.Button btnSalir;
    }
}

