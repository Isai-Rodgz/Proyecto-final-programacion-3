using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final 
{
    public partial class Menu2 : Base
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            //Codigo para llamar al formulario de docentes
            Docentes prof = new Docentes();
            this.Hide();
            prof.Show();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            // Codigo para llamar al formulario de Estudiantes
            Estudiantes alumno = new Estudiantes();
            this.Hide();
            alumno.Show();
        }
    }
}
