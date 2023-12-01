using Aplicacion_3__ingresar_al_sistema.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    public partial class trabajadores : Form
    {
        public trabajadores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores ingresados por el usuario
            string nombre = textnombre.Text;
            string apellido = textapellido.Text;
            string cargo = textcargo.Text;
            string fecha = textfecha.Text;
            string salario = textsalarioo.Text;
            string horario = texthorario.Text;
            string id = textID.Text;
            string numero = textnumtelefono.Text;
            string edad = textedad.Text;

            // Valida los datos
            if (string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(cargo) ||
                string.IsNullOrEmpty(fecha) ||
                string.IsNullOrEmpty(salario) ||
                string.IsNullOrEmpty(horario) ||
                string.IsNullOrEmpty(id) ||
                string.IsNullOrEmpty(edad))

            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos."); //aqui me debe de decir que campo es el que no estoy llenando 
                return;
            }
            Trabajador objTrabajador = new Trabajador();
            objTrabajador.nombre = nombre;
            objTrabajador.apellido = apellido;
            objTrabajador.cargo = cargo;
            objTrabajador.fechaIngreso = DateTime.Parse(fecha);
            objTrabajador.salario = Decimal.Parse(salario);
            objTrabajador.horario = horario;
            objTrabajador.idEmpleado = int.Parse(id);
            objTrabajador.numeroTelefono = numero;
            objTrabajador.edad = int.Parse(edad);

            // Luego de manejar los datos, puedes mostrar un mensaje de éxito.
            MessageBox.Show("Datos registrados con éxito.");

            // Puedes limpiar los campos si es necesario
            textnombree.Clear();
            textapellido.Clear();
            textcargo.Clear();
            textfecha.Clear();
            textsalarioo.Clear();
            texthorario.Clear();
            textID.Clear();
            textnumtelefono.Clear();
            textedad.Clear();
        }
    }
}
