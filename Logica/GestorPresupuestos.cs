using Carpinteria.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria.Logica
{
    internal class GestorPresupuestos
    {
        private ConexiónMySQL conexiónMySQL;
        private List<Presupuesto> listaPresupuestos;
        private List<Cliente> listaClientes;
        private List<DetallePresupuesto> listaDetallePresupuestos;

        public GestorPresupuestos()
        {
            conexiónMySQL = new ConexiónMySQL();
            listaClientes = new List<Cliente>();
            listaPresupuestos = new List<Presupuesto>();
            listaDetallePresupuestos = new List<DetallePresupuesto>();
        }

        internal void addDetalles(DetallePresupuesto detalle)
        {
            string QUERY = "INSERT INTO `detalle_presupuesto`(`id_presupuesto`, `id_cliente`, `descripcion`, `cantidad`, `precio_unitario`) VALUES ('" +
                detalle.presupuesto.id +"','"+ detalle.cliente.id +"','"+ detalle.descripcion +"','"+ detalle.cantidad +"','"+ detalle.precioUnitario +"')";
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void addPresupuesto(Presupuesto presupuestoSeleccionado)
        {
            string QUERY = "INSERT INTO `presupuesto`(`nombre`, `id_cliente`) VALUES ('" + presupuestoSeleccionado.nombre + "', '" + presupuestoSeleccionado.cliente.id + "')";
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                miComando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        internal List<Cliente> cargarClientes()
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

        public List<Presupuesto> cargarPresupuestos()
        {
            string QUERY = "SELECT * FROM presupuesto";
            MySqlDataReader mReader = null;
            try
            {

                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                mReader = miComando.ExecuteReader(); // aca essss
                Presupuesto unPresupuesto;
                while (mReader.Read())
                {
                    unPresupuesto = new Presupuesto();
                    unPresupuesto.id = mReader.GetInt32("id");
                    unPresupuesto.nombre = mReader.GetString("nombre");
                    unPresupuesto.cliente = listaClientes.FirstOrDefault(p => p.id == mReader.GetInt32("id_cliente"));
                    unPresupuesto.fecha = mReader.GetDateTime("fecha");
                    listaPresupuestos.Add(unPresupuesto);
                }
                mReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de SELECT PRESUPUESTOS");
            }
            return listaPresupuestos;
        }

        internal void deleteDetalle(int id)
        {
            string QUERY = "DELETE FROM `detalle_presupuesto` WHERE id=" + id;
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de DELETE DETALLES");
            }
        }

        internal List<DetallePresupuesto> getDetalles(Presupuesto presupuestoSeleccionado, Cliente clienteSeleccionado)
        {
            string QUERY = "SELECT * FROM detalle_presupuesto WHERE id_presupuesto="+ presupuestoSeleccionado.id +" AND id_cliente="+ clienteSeleccionado.id;
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                mReader = miComando.ExecuteReader(); // aca essss
                DetallePresupuesto unDetalle;
                while (mReader.Read())
                {
                    unDetalle = new DetallePresupuesto();
                    unDetalle.id = mReader.GetInt32("id");
                    unDetalle.descripcion = mReader.GetString("descripcion");
                    unDetalle.cantidad = mReader.GetInt32("cantidad");
                    unDetalle.precioUnitario = mReader.GetInt32("precio_unitario");
                    unDetalle.cliente = listaClientes.FirstOrDefault(p => p.id == mReader.GetInt32("id_cliente"));
                    unDetalle.presupuesto = listaPresupuestos.FirstOrDefault(p => p.id == mReader.GetInt32("id_presupuesto"));
                    listaDetallePresupuestos.Add(unDetalle);
                }
                mReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de SELECT DETALLES");
            }
            return listaDetallePresupuestos;
        }

        internal void setDetalles(int cantidad, string descripcion, float precioUnitario, int id)
        {
            string QUERY = "UPDATE `detalle_presupuesto` SET descripcion='" + descripcion +"', cantidad='" + cantidad 
                + "', precio_unitario='" + precioUnitario +"' WHERE id='"+  id +"'";
            try
            {
                MySqlCommand miComando = new MySqlCommand(QUERY);
                miComando.Connection = conexiónMySQL.GetConnection();
                miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de UPDATE DETALLES");
            }
        }
    }
}
