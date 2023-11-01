using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    public partial class Registrate : Form
    {
        public Registrate()
        {
            InitializeComponent();
        }

        private void Registrate_Load(object sender, EventArgs e)
        {

        }
        // Función para validar un correo electrónico
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores ingresados por el usuario
            string nombre = textnombre.Text;
            string apellidos = textpellido.Text;
            string email = textemail.Text;
            string contraseña = textcontraseña.Text;

            // Valida los datos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("El correo electrónico no es válido. Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Si llegamos aquí, los datos son válidos, puedes hacer lo que necesites con ellos
            // Por ejemplo, puedes guardarlos en una base de datos o realizar alguna otra operación.

            // Luego de manejar los datos, puedes mostrar un mensaje de éxito.
            MessageBox.Show("Datos registrados con éxito.");

            // Puedes limpiar los campos si es necesario
            textnombre.Clear();
            textpellido.Clear();
            textemail.Clear();
            textcontraseña.Clear();

            // Ahora, crea y muestra la ventana capturendatos
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
