namespace Proyecto_final 
{
    partial class Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.btnsalirB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalirB
            // 
            this.btnsalirB.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnsalirB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsalirB.Location = new System.Drawing.Point(577, 232);
            this.btnsalirB.Name = "btnsalirB";
            this.btnsalirB.Size = new System.Drawing.Size(96, 49);
            this.btnsalirB.TabIndex = 0;
            this.btnsalirB.Text = "Salir";
            this.btnsalirB.UseVisualStyleBackColor = false;
            this.btnsalirB.Click += new System.EventHandler(this.btnsalirB_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 496);
            this.Controls.Add(this.btnsalirB);
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Base_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnsalirB;
    }
}