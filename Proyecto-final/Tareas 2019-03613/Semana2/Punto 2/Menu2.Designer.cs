namespace Proyecto_final 
{
    partial class Menu2
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
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.lblmenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalirB
            // 
            this.btnsalirB.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirB.Location = new System.Drawing.Point(555, 146);
            this.btnsalirB.Size = new System.Drawing.Size(203, 120);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstudiantes.Location = new System.Drawing.Point(292, 146);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(203, 120);
            this.btnEstudiantes.TabIndex = 1;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDocentes.Location = new System.Drawing.Point(31, 146);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(203, 120);
            this.btnDocentes.TabIndex = 2;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = false;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblmenu.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.Location = new System.Drawing.Point(258, 32);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(308, 46);
            this.lblmenu.TabIndex = 3;
            this.lblmenu.Text = "Menu de entrada";
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.btnDocentes);
            this.Controls.Add(this.btnEstudiantes);
            this.Name = "Menu2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Controls.SetChildIndex(this.btnsalirB, 0);
            this.Controls.SetChildIndex(this.btnEstudiantes, 0);
            this.Controls.SetChildIndex(this.btnDocentes, 0);
            this.Controls.SetChildIndex(this.lblmenu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Label lblmenu;
    }
}