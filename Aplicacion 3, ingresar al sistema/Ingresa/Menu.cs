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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            Administracion_de_maestros maestros = new Administracion_de_maestros();
            maestros.Show();
            this.Hide();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Administracion_de_estudiantes estudiantes = new Administracion_de_estudiantes();
            estudiantes.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(); 
            inicio.Show();
            this.Hide();
        }
    }
}
