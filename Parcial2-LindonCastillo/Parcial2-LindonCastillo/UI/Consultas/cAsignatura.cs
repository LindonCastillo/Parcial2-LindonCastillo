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
    public partial class cAsignatura : Form
    {
        public cAsignatura()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            var listado = new List<Asignaturas>();
            if(Criterio_textBox.Text.Trim().Length > 0)
            {
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0:
                        listado = repositorio.GetList(p => true);
                        break;

                    case 1:
                        int id = 0;
                        if (int.TryParse(Criterio_textBox.Text,out id))
                        {
                            id = Convert.ToInt32(Criterio_textBox.Text);
                            listado = repositorio.GetList(p => p.AsignaturaId == id);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 2:
                        listado = repositorio.GetList(p => p.Descripcion.Contains(Criterio_textBox.Text));
                        break;

                    case 3:
                        int credito = 0;
                        if (int.TryParse(Criterio_textBox.Text, out credito))
                        {
                            credito = Convert.ToInt32(Criterio_textBox.Text);
                            listado = repositorio.GetList(p => p.Creditos == credito);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;
                }
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
