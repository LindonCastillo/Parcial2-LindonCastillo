using Parcial2_LindonCastillo.BLL;
using Parcial2_LindonCastillo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_LindonCastillo.UI.Registros
{
    public partial class rInscripcion : Form
    {
        public List<InscripcionDetalle> Detalle { get; set; }
        public rInscripcion()
        {
            InitializeComponent();
            this.Detalle = new List<InscripcionDetalle>();
        }

        private void Limpiar()
        {
            InscripcionId_numericUpDown.Value = 0;
            Fecha_dateTimePicker.Value = DateTime.Now;
            Monto_numericUpDown.Value = 0;
            EstudianteId_numericUpDown.Value = 0;
            Estudiante_textBox.Text = string.Empty;
            AsignaturaId_numericUpDown.Value = 0;
            Descripcion_textBox.Text = string.Empty;

            this.Detalle = new List<InscripcionDetalle>();
            CargarGrid();
        }

        private Inscripcion LlenarClase()
        {
            Inscripcion i = new Inscripcion();
            i.InscripcionId = Convert.ToInt32(InscripcionId_numericUpDown.Value);
            i.Fecha = Fecha_dateTimePicker.Value;
            i.Monto = Monto_numericUpDown.Value;
            i.Detalle = this.Detalle;

            return i;
        }

        private void LlenarCampo(Inscripcion inscripcion)
        {
            InscripcionId_numericUpDown.Value = inscripcion.InscripcionId;
            Fecha_dateTimePicker.Value = inscripcion.Fecha;
            Monto_numericUpDown.Value = inscripcion.Monto;

            this.Detalle = inscripcion.Detalle;
            CargarGrid();
        }

        private bool Validar()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            bool paso = true;
            errorProvider.Clear();

            if (Monto_numericUpDown.Value == 0){
                errorProvider.SetError(Monto_numericUpDown,"El campo Monto no puede ser cero");
                paso = false;
            }

            if (EstudianteId_numericUpDown.Value == 0)
            {
                errorProvider.SetError(EstudianteId_numericUpDown, "Tiene que buscar un estudiante por el Id");
                EstudianteId_numericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Estudiante_textBox.Text))
            {
                errorProvider.SetError(EstudianteId_numericUpDown, "Busque un estudiante por el Id");
                EstudianteId_numericUpDown.Focus();
                paso = false;
            }

            if (AsignaturaId_numericUpDown.Value == 0)
            {
                errorProvider.SetError(AsignaturaId_numericUpDown, "Tiene que buscar una asignatura por el Id");
                AsignaturaId_numericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text))
            {
                errorProvider.SetError(AsignaturaId_numericUpDown, "Busque un asignatura por el Id");
                AsignaturaId_numericUpDown.Focus();
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                errorProvider.SetError(Estudiante_textBox, "Debe agregar alguna Asignatura");
                paso = false;
            }

            return paso;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {

        }

        private void BuscarEstudiante_button_Click(object sender, EventArgs e)
        {

        }

        private void BuscarAsignatura_button_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {

        }

        private void Remover_button_Click(object sender, EventArgs e)
        {

        }
    }
}
