using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_LindonCastillo.UI.Registros;
using Parcial2_LindonCastillo.UI.Consultas;

namespace Parcial2_LindonCastillo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignatura asignaturas = new rAsignatura();
            asignaturas.Show();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes estudiantes = new rEstudiantes();
            estudiantes.Show();
        }

        private void InscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInscripcion inscripcion = new rInscripcion();
            inscripcion.Show();
        }

        private void AsignaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cAsignatura asignatura = new cAsignatura();
            asignatura.Show();
        }

        private void EstudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEstudiante estudiante = new cEstudiante();
            estudiante.Show();
        }
    }
}
