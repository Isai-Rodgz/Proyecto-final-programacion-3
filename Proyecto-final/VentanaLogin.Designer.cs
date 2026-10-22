namespace Proyecto_final
{
    partial class VentanaLogin
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
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAcc = new System.Windows.Forms.TextBox();
            this.TxtCont = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(323, 181);
            this.BtnSalir.Size = new System.Drawing.Size(175, 35);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(43, 203);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(188, 35);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuenta:";
            // 
            // TxtAcc
            // 
            this.TxtAcc.Location = new System.Drawing.Point(230, 70);
            this.TxtAcc.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtAcc.Name = "TxtAcc";
            this.TxtAcc.Size = new System.Drawing.Size(171, 26);
            this.TxtAcc.TabIndex = 0;
            this.TxtAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCont
            // 
            this.TxtCont.Location = new System.Drawing.Point(234, 127);
            this.TxtCont.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtCont.Name = "TxtCont";
            this.TxtCont.PasswordChar = '*';
            this.TxtCont.Size = new System.Drawing.Size(167, 26);
            this.TxtCont.TabIndex = 1;
            this.TxtCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VentanaLogin
            // 
            this.AcceptButton = this.BtnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 307);
            this.Controls.Add(this.TxtCont);
            this.Controls.Add(this.TxtAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIngresar);
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaLogin_FormClosed);
            this.Controls.SetChildIndex(this.BtnIngresar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtAcc, 0);
            this.Controls.SetChildIndex(this.TxtCont, 0);
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAcc;
        private System.Windows.Forms.TextBox TxtCont;
    }
}

