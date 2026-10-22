namespace Proyecto_final
{
    partial class FormOperar
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.gbxproducto = new System.Windows.Forms.GroupBox();
            this.rdbutensilios = new System.Windows.Forms.RadioButton();
            this.rdbpapel = new System.Windows.Forms.RadioButton();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtmaterial = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txttamanio = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbltamaño = new System.Windows.Forms.Label();
            this.lblmaterial = new System.Windows.Forms.Label();
            this.gbxpapel = new System.Windows.Forms.GroupBox();
            this.gbxutensilio = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.gbxproducto.SuspendLayout();
            this.gbxpapel.SuspendLayout();
            this.gbxutensilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(5, 73);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(90, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo de barras:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(98, 35);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(52, 143);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(40, 13);
            this.lblprecio.TabIndex = 3;
            this.lblprecio.Text = "Precio:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(48, 38);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(98, 105);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 5;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(98, 70);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 6;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(52, 108);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(40, 13);
            this.lblmarca.TabIndex = 7;
            this.lblmarca.Text = "Marca:";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(30, 80);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(34, 13);
            this.lblpeso.TabIndex = 8;
            this.lblpeso.Text = "Peso:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(98, 140);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 9;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(69, 77);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(100, 20);
            this.txtcolor.TabIndex = 10;
            // 
            // gbxproducto
            // 
            this.gbxproducto.Controls.Add(this.rdbutensilios);
            this.gbxproducto.Controls.Add(this.rdbpapel);
            this.gbxproducto.Controls.Add(this.lblmensaje);
            this.gbxproducto.Controls.Add(this.txtprecio);
            this.gbxproducto.Controls.Add(this.lblcodigo);
            this.gbxproducto.Controls.Add(this.txtnombre);
            this.gbxproducto.Controls.Add(this.lblprecio);
            this.gbxproducto.Controls.Add(this.lblmarca);
            this.gbxproducto.Controls.Add(this.lblnombre);
            this.gbxproducto.Controls.Add(this.txtcodigo);
            this.gbxproducto.Controls.Add(this.txtmarca);
            this.gbxproducto.Location = new System.Drawing.Point(22, 68);
            this.gbxproducto.Name = "gbxproducto";
            this.gbxproducto.Size = new System.Drawing.Size(393, 180);
            this.gbxproducto.TabIndex = 11;
            this.gbxproducto.TabStop = false;
            this.gbxproducto.Text = "Ingrese el Producto ";
            // 
            // rdbutensilios
            // 
            this.rdbutensilios.AutoSize = true;
            this.rdbutensilios.Location = new System.Drawing.Point(269, 87);
            this.rdbutensilios.Name = "rdbutensilios";
            this.rdbutensilios.Size = new System.Drawing.Size(65, 17);
            this.rdbutensilios.TabIndex = 14;
            this.rdbutensilios.Text = "Utensilio";
            this.rdbutensilios.UseVisualStyleBackColor = true;
            this.rdbutensilios.CheckedChanged += new System.EventHandler(this.rdbutensilios_CheckedChanged);
            // 
            // rdbpapel
            // 
            this.rdbpapel.AutoSize = true;
            this.rdbpapel.Checked = true;
            this.rdbpapel.Location = new System.Drawing.Point(269, 64);
            this.rdbpapel.Name = "rdbpapel";
            this.rdbpapel.Size = new System.Drawing.Size(52, 17);
            this.rdbpapel.TabIndex = 13;
            this.rdbpapel.TabStop = true;
            this.rdbpapel.Text = "Papel";
            this.rdbpapel.UseVisualStyleBackColor = true;
            this.rdbpapel.CheckedChanged += new System.EventHandler(this.rdbpapel_CheckedChanged);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(255, 35);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(119, 13);
            this.lblmensaje.TabIndex = 12;
            this.lblmensaje.Text = "Elija que quiere registrar";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(70, 42);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(100, 20);
            this.txtcategoria.TabIndex = 12;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(70, 77);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 13;
            // 
            // txtmaterial
            // 
            this.txtmaterial.Location = new System.Drawing.Point(70, 113);
            this.txtmaterial.Name = "txtmaterial";
            this.txtmaterial.Size = new System.Drawing.Size(100, 20);
            this.txtmaterial.TabIndex = 14;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(69, 42);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 15;
            // 
            // txttamanio
            // 
            this.txttamanio.Location = new System.Drawing.Point(69, 115);
            this.txttamanio.Name = "txttamanio";
            this.txttamanio.Size = new System.Drawing.Size(100, 20);
            this.txttamanio.TabIndex = 16;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(32, 45);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(31, 13);
            this.lbltipo.TabIndex = 17;
            this.lbltipo.Text = "Tipo:";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(29, 80);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(34, 13);
            this.lblcolor.TabIndex = 18;
            this.lblcolor.Text = "Color:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(9, 45);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(55, 13);
            this.lblcategoria.TabIndex = 19;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lbltamaño
            // 
            this.lbltamaño.AutoSize = true;
            this.lbltamaño.Location = new System.Drawing.Point(14, 118);
            this.lbltamaño.Name = "lbltamaño";
            this.lbltamaño.Size = new System.Drawing.Size(49, 13);
            this.lbltamaño.TabIndex = 20;
            this.lbltamaño.Text = "Tamaño:";
            // 
            // lblmaterial
            // 
            this.lblmaterial.AutoSize = true;
            this.lblmaterial.Location = new System.Drawing.Point(17, 120);
            this.lblmaterial.Name = "lblmaterial";
            this.lblmaterial.Size = new System.Drawing.Size(47, 13);
            this.lblmaterial.TabIndex = 21;
            this.lblmaterial.Text = "Material:";
            // 
            // gbxpapel
            // 
            this.gbxpapel.Controls.Add(this.txttamanio);
            this.gbxpapel.Controls.Add(this.txtcolor);
            this.gbxpapel.Controls.Add(this.lbltamaño);
            this.gbxpapel.Controls.Add(this.txttipo);
            this.gbxpapel.Controls.Add(this.lbltipo);
            this.gbxpapel.Controls.Add(this.lblcolor);
            this.gbxpapel.Location = new System.Drawing.Point(452, 68);
            this.gbxpapel.Name = "gbxpapel";
            this.gbxpapel.Size = new System.Drawing.Size(216, 150);
            this.gbxpapel.TabIndex = 22;
            this.gbxpapel.TabStop = false;
            this.gbxpapel.Text = "Papel";
            // 
            // gbxutensilio
            // 
            this.gbxutensilio.Controls.Add(this.txtmaterial);
            this.gbxutensilio.Controls.Add(this.lblpeso);
            this.gbxutensilio.Controls.Add(this.lblmaterial);
            this.gbxutensilio.Controls.Add(this.txtcategoria);
            this.gbxutensilio.Controls.Add(this.lblcategoria);
            this.gbxutensilio.Controls.Add(this.txtpeso);
            this.gbxutensilio.Location = new System.Drawing.Point(684, 68);
            this.gbxutensilio.Name = "gbxutensilio";
            this.gbxutensilio.Size = new System.Drawing.Size(205, 150);
            this.gbxutensilio.TabIndex = 23;
            this.gbxutensilio.TabStop = false;
            this.gbxutensilio.Text = "Utensilio";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(496, 244);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(76, 33);
            this.btnguardar.TabIndex = 24;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(592, 244);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(76, 33);
            this.btnnuevo.TabIndex = 25;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(685, 244);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 33);
            this.btnsalir.TabIndex = 26;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FormOperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 310);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.gbxutensilio);
            this.Controls.Add(this.gbxpapel);
            this.Controls.Add(this.gbxproducto);
            this.Name = "FormOperar";
            this.Text = "Registro de producto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxproducto.ResumeLayout(false);
            this.gbxproducto.PerformLayout();
            this.gbxpapel.ResumeLayout(false);
            this.gbxpapel.PerformLayout();
            this.gbxutensilio.ResumeLayout(false);
            this.gbxutensilio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblpeso;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtmarca;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.RadioButton rdbutensilios;
        private System.Windows.Forms.RadioButton rdbpapel;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbltamaño;
        private System.Windows.Forms.Label lblmaterial;
        private System.Windows.Forms.GroupBox gbxpapel;
        private System.Windows.Forms.GroupBox gbxutensilio;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnsalir;
        public System.Windows.Forms.TextBox txtcolor;
        public System.Windows.Forms.TextBox txtcategoria;
        public System.Windows.Forms.TextBox txtpeso;
        public System.Windows.Forms.TextBox txtmaterial;
        public System.Windows.Forms.TextBox txttipo;
        public System.Windows.Forms.TextBox txttamanio;
        public System.Windows.Forms.GroupBox gbxproducto;
        public System.Windows.Forms.Button btnguardar;
    }
}

