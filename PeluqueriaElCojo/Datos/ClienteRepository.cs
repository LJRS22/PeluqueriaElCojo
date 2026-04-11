using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo.Datos
{
    public class ClienteRepository
    {
        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            string sql = @"SELECT Id, Nombre, Telefono, Tipo, Visitas
                          FROM Clientes WHERE Activo = 1 ORDER BY Nombre";

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(MapearCliente(reader));
                }
            }
            return lista;
        }

        public List<Cliente> Buscar(string termino)
        {
            List<Cliente> lista = new List<Cliente>();
            string sql = @"SELECT Id, Nombre, Telefono, Tipo, Visitas
                          FROM Clientes WHERE Activo = 1
                          AND (Nombre LIKE @Termino OR Telefono LIKE @Termino)
                          ORDER BY Nombre";

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Termino", "%" + termino + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            lista.Add(MapearCliente(reader));
                    }
                }
            }
            return lista;
        }

        public int Insertar(Cliente cliente)
        {
            string sql = @"INSERT INTO Clientes (Nombre, Telefono, Tipo, Visitas)
                          VALUES (@Nombre, @Telefono, @Tipo, @Visitas);
                          SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Tipo", (int)cliente.Tipo);
                    cmd.Parameters.AddWithValue("@Visitas", cliente.Visitas);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool Actualizar(Cliente cliente)
        {
            string sql = @"UPDATE Clientes SET Nombre = @Nombre,
                          Telefono = @Telefono, Tipo = @Tipo,
                          Visitas = @Visitas WHERE Id = @Id";

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", cliente.Id);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Tipo", (int)cliente.Tipo);
                    cmd.Parameters.AddWithValue("@Visitas", cliente.Visitas);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Eliminar(int id)
        {
            string sql = "UPDATE Clientes SET Activo = 0 WHERE Id = @Id";
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Cliente MapearCliente(SqlDataReader reader)
        {
            string nombre = reader.GetString(1);
            string telefono = reader.GetString(2);
            Cliente c = new Cliente(nombre, telefono);
            c.Tipo = (TipoCliente)reader.GetInt32(3);

            // Reflection para setear propiedades con private set
            typeof(Cliente).GetProperty("Id")
                .SetValue(c, reader.GetInt32(0), null);
            typeof(Cliente).GetProperty("Visitas")
                .SetValue(c, reader.GetInt32(4), null);

            return c;
        }
    }
}