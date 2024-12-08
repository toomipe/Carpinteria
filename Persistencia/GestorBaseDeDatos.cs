using MySql.Data.MySqlClient;
using System;

namespace Carpinteria.Persistencia
{
    public class GestorBaseDeDatos
    {
        private ConexiónMySQL conexiónMySQL;

        // Constructor para inicializar la conexión
        public GestorBaseDeDatos()
        {
            this.conexiónMySQL = new ConexiónMySQL();
        }

        public void cargarBaseDeDatos()
        {
            string QUERY = @"
                CREATE TABLE IF NOT EXISTS `clientes` (
                  `id` int(11) NOT NULL AUTO_INCREMENT,
                  `nombre` text NOT NULL,
                  `telefono` text NOT NULL,
                  PRIMARY KEY (`id`)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

                CREATE TABLE IF NOT EXISTS `detalle_presupuesto` (
                  `id_presupuesto` int(11) NOT NULL,
                  `id_cliente` int(11) NOT NULL,
                  `id` int(11) NOT NULL AUTO_INCREMENT,
                  `descripcion` text NOT NULL,
                  `cantidad` int(11) NOT NULL,
                  `precio_unitario` int(11) NOT NULL,
                  PRIMARY KEY (`id`)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

                CREATE TABLE IF NOT EXISTS `presupuesto` (
                  `id` int(11) NOT NULL AUTO_INCREMENT,
                  `id_cliente` int(11) NOT NULL,
                  `nombre` text NOT NULL,
                  `fecha` date NOT NULL DEFAULT current_timestamp(),
                  PRIMARY KEY (`id`)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
            ";

            try
            {
                using (MySqlConnection connection = conexiónMySQL.GetConnection())
                {
                    // Asegúrate de que la conexión esté abierta
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    MySqlCommand miComando = new MySqlCommand(QUERY, connection);
                    miComando.ExecuteNonQuery(); // Ejecutar el query
                }
            }
            catch (Exception ex)
            {
                // Puedes agregar un logging o manejo más detallado del error aquí
                Console.WriteLine("Error al crear la base de datos y las tablas: " + ex.Message);
                throw;
            }
        }
    }
}
