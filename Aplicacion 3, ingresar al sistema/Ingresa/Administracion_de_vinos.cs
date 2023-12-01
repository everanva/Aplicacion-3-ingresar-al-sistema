using Aplicacion_3__ingresar_al_sistema.Modelo;
using System.Data;

namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    public partial class Administracion_de_vinos : Form
    {
        bool editando;
        int rowEditando;
        public Administracion_de_vinos()
        {
            InitializeComponent();
            editando = false;

            Producto producto = new Producto();

            DataGridView vinosGrid = datavinos;
            DataTable productosEnDb = producto.ConsultarEnDB();
            foreach (DataRow row in productosEnDb.Rows)
            {
                //Referencia a un renglon DataGridView
                DataGridViewRow renglon = (DataGridViewRow)datavinos.Rows[0].Clone();

                renglon.Cells[0].Value = row[0].ToString();
                renglon.Cells[1].Value = row[1].ToString();
                renglon.Cells[2].Value = row[2].ToString();
                renglon.Cells[3].Value = row[3].ToString();
                renglon.Cells[4].Value = row[4].ToString();
                renglon.Cells[5].Value = row[5].ToString();
                renglon.Cells[6].Value = row[6].ToString();
                renglon.Cells[7].Value = row[7].ToString();


                datavinos.Rows.Add(renglon);
            }
        }

        private void editar()
        {
            try
            {
                //Referencia a un renglon DataGridView
                DataGridViewRow renglon = (DataGridViewRow)datavinos.Rows[rowEditando];

                renglon.Cells[0].Value = textmarca.Text;
                renglon.Cells[1].Value = texttipo.Text;
                renglon.Cells[2].Value = textsabor.Text;
                renglon.Cells[3].Value = textmaridaje.Text;
                renglon.Cells[4].Value = textporcentajealcohol.Text;
                renglon.Cells[5].Value = textcantidad.Text;
                renglon.Cells[6].Value = textprecio.Text;
                renglon.Cells[7].Value = texttiempo.Text;

                // Guardar cambios en db
                Producto producto = new Producto();
                producto.marca = textmarca.Text;
                producto.tipo = texttipo.Text;
                producto.sabor = textsabor.Text;
                producto.maridaje = textmaridaje.Text;
                producto.porcentaje = float.Parse(textporcentajealcohol.Text);
                producto.cantidad = int.Parse(textcantidad.Text);
                producto.precio = int.Parse(textprecio.Text);
                producto.tiempo = texttiempo.Text;
                producto.ActualizarEnDB(producto);


                textmarca.Clear();
                texttipo.Clear();
                textsabor.Clear();
                textmaridaje.Clear();
                textporcentajealcohol.Clear();
                textcantidad.Clear();
                textprecio.Clear();
                texttiempo.Clear();

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
            if (string.IsNullOrEmpty(textmarca.Text) ||
                string.IsNullOrEmpty(texttipo.Text) ||
                string.IsNullOrEmpty(textsabor.Text) ||
                string.IsNullOrEmpty(textmaridaje.Text) ||
                string.IsNullOrEmpty(textporcentajealcohol.Text) ||
                string.IsNullOrEmpty(textcantidad.Text) ||
                string.IsNullOrEmpty(textprecio.Text) ||
                string.IsNullOrEmpty(texttiempo.Text))
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
                DataGridViewRow renglon = (DataGridViewRow)datavinos.Rows[0].Clone();

                renglon.Cells[0].Value = textmarca.Text;
                renglon.Cells[1].Value = texttipo.Text;
                renglon.Cells[2].Value = textsabor.Text;
                renglon.Cells[3].Value = textmaridaje.Text;
                renglon.Cells[4].Value = textporcentajealcohol.Text;
                renglon.Cells[5].Value = textcantidad.Text;
                renglon.Cells[6].Value = textprecio.Text;
                renglon.Cells[7].Value = texttiempo.Text;


                datavinos.Rows.Add(renglon);

                // Guardar cambios en db
                Producto producto = new Producto();
                producto.marca = textmarca.Text;
                producto.tipo = texttipo.Text;
                producto.sabor = textsabor.Text;
                producto.maridaje = textmaridaje.Text;
                producto.porcentaje = float.Parse(textporcentajealcohol.Text);
                producto.cantidad = int.Parse(textcantidad.Text);
                producto.precio = int.Parse(textprecio.Text);
                producto.tiempo = texttiempo.Text;
                producto.GuardarEnBD(producto);

                textmarca.Clear();
                texttipo.Clear();
                textsabor.Clear();
                textmaridaje.Clear();
                textporcentajealcohol.Clear();
                textcantidad.Clear();
                textprecio.Clear();
                texttiempo.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (datavinos.CurrentRow is null)
            {
                MessageBox.Show("Debes selecionar un solo renglon", "Modificando estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textmarca.Text = datavinos.CurrentRow.Cells["marca"].Value.ToString();
                texttipo.Text = datavinos.CurrentRow.Cells["tipo"].Value.ToString();
                textsabor.Text = datavinos.CurrentRow.Cells["sabor"].Value.ToString();
                textmaridaje.Text = datavinos.CurrentRow.Cells["maridaje"].Value.ToString();
                textporcentajealcohol.Text = datavinos.CurrentRow.Cells["porcentaje"].Value.ToString();
                textcantidad.Text = datavinos.CurrentRow.Cells["cantidad"].Value.ToString();
                textprecio.Text = datavinos.CurrentRow.Cells["precio"].Value.ToString();
                texttiempo.Text = datavinos.CurrentRow.Cells["tiempo"].Value.ToString();

                setEditar(true);
                rowEditando = datavinos.CurrentRow.Index;
            }
        }

        private void setEditar(bool editando)
        {
            this.editando = editando;
            btnCancelar.Enabled = editando;
            btnCancelar.Visible = editando;
        }
        //Aqui estamos limpiando los campos?
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textmarca.Clear();
            texttipo.Clear();
            textsabor.Clear();
            textmaridaje.Clear();
            textporcentajealcohol.Clear();
            textcantidad.Clear();
            textprecio.Clear();
            texttiempo.Clear();

            setEditar(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar los registros seleccionados?";
            string titulo = "Eliminar registros";

            if (datavinos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow row in datavinos.SelectedRows)
                        {
                            // Guardar cambios en db
                            Producto producto = new Producto();
                            producto.marca = row.Cells[0].Value.ToString();
                            producto.EliminarEnDB(producto);

                            datavinos.Rows.Remove(row);
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

        private void textcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void datavinos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void datavinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}







