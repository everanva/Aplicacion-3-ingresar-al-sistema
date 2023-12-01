using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_3__ingresar_al_sistema.Modelo
{
    public class Usuario
    {
        public string apellido_materno {  get; set; }
        public string apellido_paterno { get; set; }
        public string contrasena { get; set; }
        public int edad { get; set; }
        public string email { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string usuario { get; set; }

        public const string connectionString = "datasource=34.174.55.147;port=3306;username=vinateria;password=Vinateria123!";

        public bool validarUsuario(Usuario usuario)
        {
            try
            {
                
                //Display query
                string Query = "select * from vinateriadeevelyn.tabla_usuario where usuario = '" + usuario.usuario + "' and contrasena = '" + usuario.contrasena + "'";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0) { return true; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool GuardarEnBD(Usuario usuario)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into vinateriadeevelyn.tabla_usuario(usuario, apellido_materno, apellido_paterno, contrasena, edad, email, nombre, telefono) values('" +
                    usuario.usuario + "','" +
                    usuario.apellido_materno + "','" + 
                    usuario.apellido_paterno+ "','" + 
                    usuario.contrasena + "'," +
                    usuario.edad + ",'" + 
                    usuario.email + "','" + 
                    usuario.nombre + "','" + 
                    usuario.telefono + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
