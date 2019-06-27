using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_LindonCastillo.Entidades;
using Parcial2_LindonCastillo.BLL;

namespace Parcial2_LindonCastillo.UI.Registros
{
    public partial class rAsignatura : Form
    {
        public rAsignatura()
        {
            InitializeComponent();
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            AsignaturaId_numericUpDown.Value = 0;
            Descripcion_textBox.Text = string.Empty;
            Creditos_numericUpDown.Value = 0;
        }

        private bool Validar()
        {
            ErrorProvider.Clear();
            bool paso = true;
            if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text))
            {
                ErrorProvider.SetError(Descripcion_textBox, "El campo Descripción no puede estar vacío");
                paso = false;
            }

            if(Creditos_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(Creditos_numericUpDown, "El valor de este campo no puede ser 0");
                paso = false;
            }

            return paso;
        }

        private Asignaturas LlenarClase()
        {
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturaId = Convert.ToInt32(AsignaturaId_numericUpDown.Value);
            asignaturas.Descripcion = Convert.ToString(Descripcion_textBox.Text.Trim());
            asignaturas.Creditos = Convert.ToInt32(Creditos_numericUpDown.Value);

            return asignaturas;
        }

        private void LlenarCampos(Asignaturas asignaturas)
        {
            AsignaturaId_numericUpDown.Value = asignaturas.AsignaturaId;
            Descripcion_textBox.Text = asignaturas.Descripcion;
            Creditos_numericUpDown.Value = asignaturas.Creditos;
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = repositorio.Buscar((int)AsignaturaId_numericUpDown.Value);
            return (asignaturas != null);
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            asignaturas = LlenarClase();

            if (AsignaturaId_numericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(asignaturas);
            }
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar una asignatura que no existe","Fallo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(asignaturas);
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
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            ErrorProvider.Clear();
            int id = Convert.ToInt32(AsignaturaId_numericUpDown.Value);

            Limpiar();
            try
            {
                if (repositorio.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta asignatura", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error eliminando");
            }


        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas;
            int id = Convert.ToInt32(AsignaturaId_numericUpDown.Value);

            
            Limpiar();
            try
            {
                asignaturas = repositorio.Buscar(id);

                if(asignaturas != null)
                {
                    LlenarCampos(asignaturas);
                    MessageBox.Show("Asignatura Encontrada!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asignatura No Encontrado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un Error al buscar");
            }
        }



    }
}
