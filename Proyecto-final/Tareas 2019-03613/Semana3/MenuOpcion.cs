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
    public partial class MenuOpcion : Form
    {
        public MenuOpcion()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            //Se llama el formulario de alumnos
            FormAlumnos alumno = new FormAlumnos();
            this.Hide();
            alumno.Show();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            //Se llama el formulario de materias
            FormMaterias materia = new FormMaterias();
            this.Hide();
            materia.Show();
        }
    }
}
