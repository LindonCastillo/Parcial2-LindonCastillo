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

namespace Parcial2_LindonCastillo.UI.Consultas
{
    public partial class cEstudiante : Form
    {
        public cEstudiante()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            var listado = new List<Estudiantes>();
            if (Criterio_textBox.Text.Trim().Length > 0)
            {
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = repositorio.GetList(p => true);
                        break;

                    case 1://Id
                        int id = 0;
                        if (int.TryParse(Criterio_textBox.Text, out id))
                        {
                            id = Convert.ToInt32(Criterio_textBox.Text);
                            listado = repositorio.GetList(p => p.EstudianteId == id);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 2://Nombre
                        listado = repositorio.GetList(p => p.Nombre.Contains(Criterio_textBox.Text));
                        break;

                    case 3://Balance
                        decimal balance = 0;
                        if (decimal.TryParse(Criterio_textBox.Text, out balance))
                        {
                            balance = Convert.ToDecimal(Criterio_textBox.Text);
                            listado = repositorio.GetList(p => p.Balance == balance);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;
                }

                listado = listado.Where(c => c.FechaIngreso.Date >= Desde_dateTimePicker.Value.Date && c.FechaIngreso.Date <= Hasta_dateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            Consulta_dataGridView.DataSource = null;
            Consulta_dataGridView.DataSource = listado;
        }
    }
}
