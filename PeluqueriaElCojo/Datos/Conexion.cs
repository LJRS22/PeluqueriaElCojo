using System;
using System.Data.SqlClient;

namespace PeluqueriaElCojo.Datos
{
    // Clase que maneja la conexion a SQL Server
    // Todos los repositorios la usan para obtener una conexion
    public static class Conexion
    {
        // Cadena de conexion apuntando a nuestro servidor JOHANSEL05
        private static readonly string _cadenaConexion =
            @"Server=JOHANSEL05;Database=PeluqueriaElCojo;Trusted_Connection=True;";

        // Devuelve una nueva conexion lista para usar
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }

        // Prueba si la conexion funciona al arrancar el sistema
        public static bool ProbarConexion(out string mensaje)
        {
            try
            {
                using (SqlConnection conn = ObtenerConexion())
                {
                    conn.Open();
                    mensaje = "Conexion exitosa a: " + conn.Database;
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error de conexion: " + ex.Message;
                return false;
            }
        }
    }
}