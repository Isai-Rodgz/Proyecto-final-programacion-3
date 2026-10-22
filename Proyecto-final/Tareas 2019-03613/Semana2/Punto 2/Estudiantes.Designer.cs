namespace Proyecto_final 
{
    partial class Estudiantes
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registro de Estudiantes";
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 502);
            this.Controls.Add(this.label4);
            this.Name = "Estudiantes";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            this.Controls.SetChildIndex(this.gbxregistro, 0);
            this.Controls.SetChildIndex(this.btnsalirB, 0);
            this.Controls.SetChildIndex(this.btnlimpiaR, 0);
            this.Controls.SetChildIndex(this.btnModificarR, 0);
            this.Controls.SetChildIndex(this.btnguardarR, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.gbxregistro.ResumeLayout(false);
            this.gbxregistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
    }
}