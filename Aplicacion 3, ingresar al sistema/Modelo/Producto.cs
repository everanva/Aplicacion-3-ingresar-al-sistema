using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_3__ingresar_al_sistema.Modelo
{
    public class Producto
    {
        public string marca { get; set; }
        public string tipo { get; set; }
        public string sabor { get; set; }
        public string maridaje { get; set; }
        public float porcentaje { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
        public string tiempo { get; set; }
        public const string connectionString = "datasource=localhost;port=3306;username=appvinateria;password=appvinateria";


        public bool GuardarEnBD(Producto producto)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into vinateriadeevelyn.tabla_producto(marca, tipo, sabor, maridaje, porcentaje_alcohol, cantidad_del_vino, precio, tiempo_de_reserva) values('" +
                    producto.marca + "','" +
                    producto.tipo + "','" +
                    producto.sabor + "','" +
                    producto.maridaje + "'," +
                    producto.porcentaje + "," +
                    producto.cantidad + "," +
                    producto.precio + ",'" +
                    producto.tiempo + "');";
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

        public bool ActualizarEnDB(Producto producto)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "update vinateriadeevelyn.tabla_producto set marca = '" + 
                    producto.marca + "', tipo = '" + 
                    producto.tipo + "', sabor = '" +
                    producto.sabor + "', maridaje = '" +
                    producto.maridaje + "', porcentaje_alcohol = '" +
                    producto.porcentaje + "', cantidad_del_vino = " +
                    producto.cantidad + ", precio = " + 
                    producto.precio + ", tiempo_de_reserva = '" +
                    producto.tiempo + "' where marca = '" +
                    producto.marca + "'";
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

        public bool EliminarEnDB(Producto producto)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "delete FROM vinateriadeevelyn.tabla_producto where marca = '" +
                    producto.marca + "'";
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

        public DataTable ConsultarEnDB()
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "select * from vinateriadeevelyn.tabla_producto";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
