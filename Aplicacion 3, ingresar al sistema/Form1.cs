using Aplicacion_3__ingresar_al_sistema.Ingresa;
using Microsoft.Win32;
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
        private const string contrase�aCorrecta = "Cbtis75";
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
            MessageBox.Show("Ya no tienes intentos. La aplicaci�n se suspendera.");
            formularioBloqueado = true;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administracion_de_estudiantes Admi = new Administracion_de_estudiantes();
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
                MessageBox.Show("Tus intentos se agotaron. La aplicaci�n se cerrar�.");
                Application.Exit();
                return;
            }

            string usuario = textUsuario.Text;
            string contrase�a = textContrase�a.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrase�a))
            {
                MessageBox.Show("Por favor, debe llenar todos los campos.");
            }
            else if (usuario.Length < 3)
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 3 caracteres.");
            }
            else if (usuario == usuarioCorrecto && contrase�a != contrase�aCorrecta)
            {
                intentosRestantes--;
                if (intentosRestantes > 0)
                {
                    MessageBox.Show("Contrase�a incorrecta. Intentos restantes: " + intentosRestantes);
                }
                else
                {
                    BloquearFormulario();
                }
            }
            else if (usuario != usuarioCorrecto && contrase�a == contrase�aCorrecta)
            {
                intentosRestantes--;
                if (intentosRestantes > 0)
                {
                    MessageBox.Show("Usuario incorrecto. Intentos restantes: " + intentosRestantes);
                }
                else
                {
                    BloquearFormulario();
                }
            }
            else if (usuario == usuarioCorrecto && contrase�a == contrase�aCorrecta)
            {
                MessageBox.Show("�Bienvenido, Evelyn!");
                this.Hide(); // Oculta la ventana de login
                             // Aqu� debes mostrar la pantalla principal o realizar cualquier otra acci�n que desees.

                Menu menu = new Menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrate registrate = new Registrate();
            registrate.Show();
            this.Hide();
        }
    }
}
