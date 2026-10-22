namespace Proyecto_final 
{
    partial class Docentes
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmateria_D = new System.Windows.Forms.TextBox();
            this.lblmateria_D = new System.Windows.Forms.Label();
            this.gbxregistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardarR
            // 
            this.btnguardarR.Click += new System.EventHandler(this.btnguardarR_Click);
            // 
            // btnlimpiaR
            // 
            this.btnlimpiaR.Click += new System.EventHandler(this.btnlimpiaR_Click);
            // 
            // gbxregistro
            // 
            this.gbxregistro.Controls.Add(this.lblmateria_D);
            this.gbxregistro.Controls.Add(this.txtmateria_D);
            this.gbxregistro.Controls.SetChildIndex(this.txtusuario_R, 0);
            this.gbxregistro.Controls.SetChildIndex(this.txt_codigo_R, 0);
            this.gbxregistro.Controls.SetChildIndex(this.txtnomb_R, 0);
            this.gbxregistro.Controls.SetChildIndex(this.txtmateria_D, 0);
            this.gbxregistro.Controls.SetChildIndex(this.lblmateria_D, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Materia:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(108, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(287, 29);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Registro de Docentes";
            // 
            // txtmateria_D
            // 
            this.txtmateria_D.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmateria_D.Location = new System.Drawing.Point(99, 168);
            this.txtmateria_D.Name = "txtmateria_D";
            this.txtmateria_D.Size = new System.Drawing.Size(290, 29);
            this.txtmateria_D.TabIndex = 9;
            // 
            // lblmateria_D
            // 
            this.lblmateria_D.AutoSize = true;
            this.lblmateria_D.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmateria_D.Location = new System.Drawing.Point(8, 171);
            this.lblmateria_D.Name = "lblmateria_D";
            this.lblmateria_D.Size = new System.Drawing.Size(73, 21);
            this.lblmateria_D.TabIndex = 10;
            this.lblmateria_D.Text = "Materia:";
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 502);
            this.Controls.Add(this.label5);
            this.Name = "Docentes";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.Docentes_Load);
            this.Controls.SetChildIndex(this.gbxregistro, 0);
            this.Controls.SetChildIndex(this.btnsalirB, 0);
            this.Controls.SetChildIndex(this.btnlimpiaR, 0);
            this.Controls.SetChildIndex(this.btnModificarR, 0);
            this.Controls.SetChildIndex(this.btnguardarR, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.gbxregistro.ResumeLayout(false);
            this.gbxregistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmateria_D;
        public System.Windows.Forms.TextBox txtmateria_D;
    }
}