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
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiantes;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            estudiantes = LlenarClase();

            if (EstudianteId_numericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(estudiantes);
            }
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar un estudiante que no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(estudiantes);
                MessageBox.Show("Se modifico con Exito!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar!!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            errorProvider.Clear();
            int id = Convert.ToInt32(EstudianteId_numericUpDown.Value);

            Limpiar();
            try
            {
                if (repositorio.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar este estudiante", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error eliminando");
            }
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiantes;
            int id = Convert.ToInt32(EstudianteId_numericUpDown.Value);


            Limpiar();
            try
            {
                estudiantes = repositorio.Buscar(id);

                if (estudiantes != null)
                {
                    LlenarCampos(estudiantes);
                    MessageBox.Show("Estudiante Encontrada!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Estudiante No Encontrado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un Error al buscar");
            }
        }

        private void Limpiar()
        {
            EstudianteId_numericUpDown.Value = 0;
            FechaIngreso_dateTimePicker.Value = DateTime.Now;
            Nombre_textBox.Text = string.Empty;
            Balance_numericUpDown.Value = 0;
        }

        private bool Validar()
        {
            errorProvider.Clear();
            bool paso = true;
            if (string.IsNullOrWhiteSpace(Nombre_textBox.Text))
            {
                errorProvider.SetError(Nombre_textBox, "El campo Nombre no puede estar vacío");
                paso = false;
            }


            return paso;
        }

        private Estudiantes LlenarClase()
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = Convert.ToInt32(EstudianteId_numericUpDown.Value);
            estudiantes.FechaIngreso = FechaIngreso_dateTimePicker.Value;
            estudiantes.Nombre = Nombre_textBox.Text.Trim();
            estudiantes.Balance = Balance_numericUpDown.Value;

            return estudiantes;
        }

        private void LlenarCampos(Estudiantes estudiantes)
        {
            EstudianteId_numericUpDown.Value = estudiantes.EstudianteId;
            FechaIngreso_dateTimePicker.Value = estudiantes.FechaIngreso;
            Nombre_textBox.Text = estudiantes.Nombre;
            Balance_numericUpDown.Value = estudiantes.Balance;
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiantes = repositorio.Buscar((int)EstudianteId_numericUpDown.Value);
            return (estudiantes != null);
        }
    }
}
