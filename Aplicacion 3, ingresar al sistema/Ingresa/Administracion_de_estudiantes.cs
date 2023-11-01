using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    public partial class Administracion_de_estudiantes : Form
    {
        bool editando;
        int rowEditando;
        public Administracion_de_estudiantes()
        {
            InitializeComponent();
            editando = false;
        }

        private void editar()
        {
            try
            {
                //Referencia a un renglon DataGridView
                DataGridViewRow renglon = (DataGridViewRow)dataestudiante.Rows[rowEditando];

                renglon.Cells[0].Value = textnombre.Text;
                renglon.Cells[1].Value = textapellidos.Text;
                renglon.Cells[2].Value = textNocontrol.Text;
                renglon.Cells[3].Value = textcarrera.Text;
                renglon.Cells[4].Value = textgrupo.Text;

                textnombre.Clear();
                textapellidos.Clear();
                textNocontrol.Clear();
                textcarrera.Clear();
                textgrupo.Clear();

                setEditar(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al editar estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textnombre.Text) ||
                string.IsNullOrEmpty(textapellidos.Text) ||
                string.IsNullOrEmpty(textNocontrol.Text) ||
                string.IsNullOrEmpty(textcarrera.Text) ||
                string.IsNullOrEmpty(textgrupo.Text))
            {
                MessageBox.Show("Por favor, debe llenar todos los campos.");
                return;
            }

            if (editando)
            {
                editar();
                return;
            }

            try
            {
                //Referencia a un renglon DataGridView
                DataGridViewRow renglon = (DataGridViewRow)dataestudiante.Rows[0].Clone();

                renglon.Cells[0].Value = textnombre.Text;
                renglon.Cells[1].Value = textapellidos.Text;
                renglon.Cells[2].Value = textNocontrol.Text;
                renglon.Cells[3].Value = textcarrera.Text;
                renglon.Cells[4].Value = textgrupo.Text;

                dataestudiante.Rows.Add(renglon);

                textnombre.Clear();
                textapellidos.Clear();
                textNocontrol.Clear();
                textcarrera.Clear();
                textgrupo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataestudiante.CurrentRow is null)
            {
                MessageBox.Show("Debes selecionar un solo renglon", "Modificando estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textnombre.Text = dataestudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                textapellidos.Text = dataestudiante.CurrentRow.Cells["Apellidos"].Value.ToString();
                textNocontrol.Text = dataestudiante.CurrentRow.Cells["NoControl"].Value.ToString();
                textcarrera.Text = dataestudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                textgrupo.Text = dataestudiante.CurrentRow.Cells["Grupo"].Value.ToString();

                setEditar(true);
                rowEditando = dataestudiante.CurrentRow.Index;
            }
        }

        private void setEditar(bool editando)
        {
            this.editando = editando;
            btnCancelar.Enabled = editando;
            btnCancelar.Visible = editando;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textnombre.Clear();
            textapellidos.Clear();
            textNocontrol.Clear();
            textcarrera.Clear();
            textgrupo.Clear();

            setEditar(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar los registros seleccionados?";
            string titulo = "Eliminar registros";

            if (dataestudiante.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataestudiante.SelectedRows)
                        {
                            dataestudiante.Rows.Remove(row);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al eliminar estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes selecionar un renglon", "Eliminado estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}


