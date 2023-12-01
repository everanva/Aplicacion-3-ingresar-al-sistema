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

namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    public partial class usuario : Form
    {
        public usuario()
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
            string usuario = textusuario.Text;
            string nombre = textnombre.Text;
            string apellidoPaterno = textpellido.Text;
            string apellidoMaterno = textApellidoMaterno.Text;
            string email = textemail.Text;
            string contrasena = textcontrasena.Text;
            string telefono = texttelefono.Text;
            string edad = textedad.Text;

            // Valida los datos
            if (string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(apellidoPaterno) ||
                string.IsNullOrEmpty(apellidoMaterno) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(contrasena) ||
                string.IsNullOrEmpty(telefono) ||
                string.IsNullOrEmpty(edad))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos."); //aqui me debe de decir que campo es el que no estoy llenando 
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("El correo electrónico no es válido. Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Si llegamos aquí, los datos son válidos, puedes hacer lo que necesites con ellos
            // Por ejemplo, puedes guardarlos en una base de datos o realizar alguna otra operación.
            Usuario objUsuario = new Usuario();
            objUsuario.usuario = usuario;
            objUsuario.nombre = nombre;
            objUsuario.apellido_paterno = apellidoPaterno;
            objUsuario.apellido_materno = apellidoMaterno;
            objUsuario.email = email;
            objUsuario.telefono = telefono;
            objUsuario.contrasena = contrasena;
            objUsuario.edad = int.Parse(edad);
            objUsuario.GuardarEnBD(objUsuario);


            // Luego de manejar los datos, puedes mostrar un mensaje de éxito.
            MessageBox.Show("Datos registrados con éxito.");

            // Puedes limpiar los campos si es necesario
            textusuario.Clear();
            textnombre.Clear();
            textpellido.Clear();
            textApellidoMaterno.Clear();
            textemail.Clear();
            texttelefono.Clear();
            textedad.Clear();
            textcontrasena.Clear();


            // Ahora, crea y muestra la ventana capturendatos
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
    }
}
