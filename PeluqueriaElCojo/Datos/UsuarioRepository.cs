using System.Data.SqlClient;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo.Datos
{
    // Repositorio para autenticar usuarios contra la base de datos
    public class UsuarioRepository
    {
        // Verifica usuario y contrasena y devuelve el usuario si es valido
        public Usuario Autenticar(string usuario, string contrasena)
        {
            string sql = @"SELECT Id, Usuario, Contrasena, Rol, Activo
                          FROM Usuarios
                          WHERE Usuario = @Usuario
                          AND Contrasena = @Contrasena
                          AND Activo = 1";

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario u = new Usuario();
                            u.Id = reader.GetInt32(0);
                            u.NombreUsuario = reader.GetString(1);
                            u.Contrasena = reader.GetString(2);
                            u.Rol = (RolSistema)reader.GetInt32(3);
                            u.Activo = reader.GetBoolean(4);
                            return u;
                        }
                    }
                }
            }
            return null;
        }
    }
}