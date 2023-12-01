using Aplicacion_3__ingresar_al_sistema.Ingresa;
using Aplicacion_3__ingresar_al_sistema.Modelo;
using Microsoft.Win32;
using MySqlConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_3__ingresar_al_sistema

{
    public partial class Form1 : Form
    {
        private int intentosRestantes = 5;
        private const string usuarioCorrecto = "Evelyn";
        private const string contraseñaCorrecta = "Cbtis75";
        private bool formularioBloqueado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {


        }
        private void BloquearFormulario()
        {
            MessageBox.Show("Ya no tienes intentos. La aplicación se suspendera.");
            formularioBloqueado = true;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administracion_de_vinos Admi = new Administracion_de_vinos();
            Admi.Show();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formularioBloqueado)
            {
                MessageBox.Show("Tus intentos se agotaron. La aplicación se cerrará.");
                Application.Exit();
                return;
            }

            string usuario = textUsuario.Text;
            string contrasena = textContrasena.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, debe llenar todos los campos.");
            }
            else if (usuario.Length < 3)
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 3 caracteres.");
            }
            else if (usuario != usuarioCorrecto || contrasena != contraseñaCorrecta)
            {
                Usuario objUsuario = new Usuario();
                objUsuario.usuario = usuario;
                objUsuario.contrasena = contrasena;
                if(objUsuario.validarUsuario(objUsuario))
                {
                    MessageBox.Show("¡Bienvenido, " + usuario + "!");
                    this.Hide(); // Oculta la ventana de login
                                 // Aquí debes mostrar la pantalla principal o realizar cualquier otra acción que desees.

                    Menu menu = new Menu();
                    menu.Show();
                } else
                {
                    intentosRestantes--;
                    if (intentosRestantes > 0)
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos. Intentos restantes: " + intentosRestantes);
                    }
                    else
                    {
                        BloquearFormulario();
                    }
                }
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            usuario registrate = new usuario();
            registrate.Show();
            this.Hide();
        }
    }
}
