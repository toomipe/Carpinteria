using Carpinteria.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Carpinteria.Logica
{
    internal class GestorClientes
    {
        private List<Cliente> listaClientes;
        private ConexiónMySQL conexiónMySQL;

        public GestorClientes()
        {
            conexiónMySQL = new ConexiónMySQL();
            listaClientes = new List<Cliente>();
        }

        public List<Cliente> getClientes()
        {
            string QUERY = "SELECT * FROM clientes";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                mReader = miComando.ExecuteReader();

                Cliente unCliente;
                while (mReader.Read())
                {
                    unCliente = new Cliente();
                    unCliente.id = mReader.GetInt32("id");
                    unCliente.nombre = mReader.GetString("nombre");
                    unCliente.telefono = mReader.GetString("telefono");
                    listaClientes.Add(unCliente);
                }
                mReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de SELECT CLIENTES");
            }
            return listaClientes;
        }

        public void addCliente(Cliente cliente)
        {
            string QUERY = "INSERT INTO `clientes`(`nombre`, `telefono`) VALUES ('" + cliente.nombre + "','" + cliente.telefono + "')";
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de INSERT CLIENTES");
            }
        }

        internal void setClientes(int id, string nombre, string telefono)
        {
            string QUERY = "UPDATE `clientes` SET nombre='" + nombre + "', telefono='" + telefono + "' WHERE id='" + id + "'";
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de UPDATE clientes");
            }
        }

        internal void deleteCliente(int id)
        {
            string QUERY = "DELETE FROM `clientes` WHERE id=" + id;
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de DELETE clientes");
            }
        }
    }
}
