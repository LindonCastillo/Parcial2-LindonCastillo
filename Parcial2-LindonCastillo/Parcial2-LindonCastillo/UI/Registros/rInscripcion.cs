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
            PrecioCredito_numericUpDown.Value = 0;
            Monto_textBox.Text = string.Empty;
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
            i.Monto = Convert.ToDecimal(Monto_textBox.Text);
            i.Detalle = this.Detalle;

            return i;
        }

        private void LlenarCampo(Inscripcion inscripcion)
        {
            InscripcionId_numericUpDown.Value = inscripcion.InscripcionId;
            Fecha_dateTimePicker.Value = inscripcion.Fecha;
            Monto_textBox.Text = Convert.ToString(inscripcion.Monto);

            this.Detalle = inscripcion.Detalle;
            CargarGrid();
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (PrecioCredito_numericUpDown.Value == 0){
                errorProvider.SetError(PrecioCredito_numericUpDown, "El campo Precio Credito no puede ser cero");
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                errorProvider.SetError(Detalle_dataGridView, "Debe agregar alguna Asignatura");
                paso = false;
            }

            return paso;
        }

        private bool Validar2()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            bool paso = true;
            errorProvider.Clear();

            if (PrecioCredito_numericUpDown.Value == 0)
            {
                errorProvider.SetError(PrecioCredito_numericUpDown, "El campo Precio Credito no puede ser cero");
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

            return paso;
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            Inscripcion inscripcion = InscripcionBLL.Buscar((int)InscripcionId_numericUpDown.Value);
            return (inscripcion != null);
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            inscripcion = LlenarClase();

            if (InscripcionId_numericUpDown.Value == 0)
            {
                paso = InscripcionBLL.Guardar(inscripcion);
            }
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar una inscripción que no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                 paso = InscripcionBLL.Modificar(inscripcion);

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
            errorProvider.Clear();
            int id;
            int.TryParse(InscripcionId_numericUpDown.Text, out id);

            try
            {
                if (InscripcionBLL.Eliminar(id))
                {
                    InscripcionBLL.Descontar(Detalle[0].EstudianteId,decimal.Parse(Monto_textBox.Text));
                    Limpiar();
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta Inscripción", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar");
            }

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion;
            int id = Convert.ToInt32(InscripcionId_numericUpDown.Value);

            Limpiar();
            try
            {
                
                inscripcion = InscripcionBLL.Buscar(id);
                if(inscripcion != null)
                {
                    LlenarCampo(inscripcion);
                    MessageBox.Show("Inscripción Encontrada!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Inscripción No Encontrada!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
               MessageBox.Show("No se pudo buscar");
            }


        }

        private void BuscarEstudiante_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiantes;
            if(EstudianteId_numericUpDown.Value != 0)
            {
                try
                {
                    estudiantes = repositorio.Buscar((int)EstudianteId_numericUpDown.Value);
                    Estudiante_textBox.Text = estudiantes.Nombre;
                }
                catch (Exception)
                {
                    MessageBox.Show("Estudiante no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Debe poner un Id Para buscar a un estudiante");
            }
        }

        private void BuscarAsignatura_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura;
            if (AsignaturaId_numericUpDown.Value != 0)
            {
                try
                {
                    Asignatura = repositorio.Buscar((int)AsignaturaId_numericUpDown.Value);
                    Descripcion_textBox.Text = Asignatura.Descripcion;
                }
                catch (Exception)
                {
                    MessageBox.Show("Asignatura no encontrada");
                }
            }
            else
            {
                MessageBox.Show("Debe poner un Id Para buscar a una asignatura");
            }
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            if (!Validar2())
            {
                return;
            }

            if (Detalle.Any(A => A.AsignaturaId == AsignaturaId_numericUpDown.Value))
            {
                MessageBox.Show("Esta asignatura ya esta inscrita", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Asignaturas Asignatura;
            Asignatura = repositorio.Buscar((int)AsignaturaId_numericUpDown.Value);

            if (Detalle_dataGridView.DataSource != null)
                this.Detalle = (List < InscripcionDetalle >)Detalle_dataGridView.DataSource;


            this.Detalle.Add(
                new InscripcionDetalle(
                    Id: 0,
                    InscripcionId: (int)InscripcionId_numericUpDown.Value,
                    EstudianteId: (int)EstudianteId_numericUpDown.Value,
                    AsignaturaId: (int)AsignaturaId_numericUpDown.Value,
                    Subtotal: Asignatura.Creditos*PrecioCredito_numericUpDown.Value
                    )
                );
            CargarGrid();
            AsignaturaId_numericUpDown.Focus();
            AsignaturaId_numericUpDown.Value = 0;
            Descripcion_textBox.Clear();


            Monto_textBox.Text = CalculoMonto().ToString();
        }

        public decimal CalculoMonto()
        {
            decimal monto = 0;

            foreach (var item in Detalle)
            {
                monto += item.Subtotal;
            }

            return monto;
        }

        private void CargarGrid()
        {
            Detalle_dataGridView.DataSource = null;
            Detalle_dataGridView.DataSource = this.Detalle;
        }

        private void Remover_button_Click_1(object sender, EventArgs e)
        {
            if (Detalle_dataGridView.Rows.Count > 0 && Detalle_dataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(Detalle_dataGridView.CurrentRow.Index);
                CargarGrid();
                Monto_textBox.Text = CalculoMonto().ToString();
            }
        }
    }
}
