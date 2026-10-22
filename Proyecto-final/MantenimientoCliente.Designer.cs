namespace Proyecto_final
{
    partial class MantenimientoCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCli = new MyLibreria.ErrorTextBox();
            this.txtApeCli = new MyLibreria.ErrorTextBox();
            this.txtNomCli = new MyLibreria.ErrorTextBox();
            this.lblestatus = new System.Windows.Forms.Label();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(434, 65);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 140);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 215);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(434, 291);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(434, 363);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Cliente:";
            // 
            // txtIdCli
            // 
            this.txtIdCli.Location = new System.Drawing.Point(120, 96);
            this.txtIdCli.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(125, 25);
            this.txtIdCli.SoloNumeros = true;
            this.txtIdCli.TabIndex = 16;
            this.txtIdCli.Validar = true;
            this.txtIdCli.TextChanged += new System.EventHandler(this.txtIdCli_TextChanged);
            // 
            // txtApeCli
            // 
            this.txtApeCli.Location = new System.Drawing.Point(120, 323);
            this.txtApeCli.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtApeCli.Name = "txtApeCli";
            this.txtApeCli.Size = new System.Drawing.Size(125, 25);
            this.txtApeCli.SoloNumeros = false;
            this.txtApeCli.TabIndex = 17;
            this.txtApeCli.Validar = true;
            this.txtApeCli.TextChanged += new System.EventHandler(this.txtApeCli_TextChanged);
            // 
            // txtNomCli
            // 
            this.txtNomCli.Location = new System.Drawing.Point(120, 205);
            this.txtNomCli.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(125, 25);
            this.txtNomCli.SoloNumeros = false;
            this.txtNomCli.TabIndex = 18;
            this.txtNomCli.Validar = true;
            this.txtNomCli.TextChanged += new System.EventHandler(this.txtNomCli_TextChanged);
            // 
            // lblestatus
            // 
            this.lblestatus.AutoSize = true;
            this.lblestatus.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestatus.Location = new System.Drawing.Point(35, 396);
            this.lblestatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblestatus.Name = "lblestatus";
            this.lblestatus.Size = new System.Drawing.Size(59, 25);
            this.lblestatus.TabIndex = 19;
            this.lblestatus.Text = "Estatus:";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(107, 400);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(53, 22);
            this.rdbActivo.TabIndex = 20;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(177, 400);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(59, 22);
            this.rdbInactivo.TabIndex = 21;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 446);
            this.Controls.Add(this.rdbInactivo);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.lblestatus);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.txtApeCli);
            this.Controls.Add(this.txtIdCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.Name = "MantenimientoCliente";
            this.Text = "MatenimientoCliente";
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdCli, 0);
            this.Controls.SetChildIndex(this.txtApeCli, 0);
            this.Controls.SetChildIndex(this.txtNomCli, 0);
            this.Controls.SetChildIndex(this.lblestatus, 0);
            this.Controls.SetChildIndex(this.rdbActivo, 0);
            this.Controls.SetChildIndex(this.rdbInactivo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MyLibreria.ErrorTextBox txtIdCli;
        private MyLibreria.ErrorTextBox txtApeCli;
        private MyLibreria.ErrorTextBox txtNomCli;
        private System.Windows.Forms.Label lblestatus;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
    }
}