using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo.Datos
{
    public class EmpleadoRepository
    {
        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> lista = new List<Empleado>();
            string sql = @"SELECT Id, Nombre, Apodo, Cedula, Telefono, Rol,
                          SalarioBase, PorcentajeComision, VentasMes, Activo
                          FROM Empleados WHERE Activo = 1 ORDER BY Nombre";

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(MapearEmpleado(reader));
                }
            }
            return lista;
        }

        public List<Empleado> ObtenerBarberos()
        {
            List<Empleado> lista = new List<Empleado>();
            string sql = @"SELECT Id, Nombre, Apodo, Cedula, Telefono, Rol,
                          SalarioBase, PorcentajeComision, VentasMes, Activo
                          FROM Empleados WHERE Activo = 1 AND Rol = 0
                          ORDER BY VentasMes DESC";

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(MapearEmpleado(reader));
                }
            }
            return lista;
        }

        public int Insertar(Empleado emp)
        {
            string sql = @"INSERT INTO Empleados
                          (Nombre, Apodo, Cedula, Telefono, Rol, SalarioBase, PorcentajeComision)
                          VALUES (@Nombre, @Apodo, @Cedula, @Telefono, @Rol, @Salario, @Comision);
                          SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                    cmd.Parameters.AddWithValue("@Apodo", (object)emp.Apodo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cedula", emp.Cedula);
                    cmd.Parameters.AddWithValue("@Telefono", (object)emp.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Rol", (int)emp.Rol);
                    cmd.Parameters.AddWithValue("@Salario", emp.SalarioBase);
                    cmd.Parameters.AddWithValue("@Comision", emp.PorcentajeComision);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool ActualizarVentas(int empleadoId, decimal monto)
        {
            string sql = "UPDATE Empleados SET VentasMes = VentasMes + @Monto WHERE Id = @Id";
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", empleadoId);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Empleado MapearEmpleado(SqlDataReader reader)
        {
            Empleado e = new Empleado();

            // Reflection para setear el Id que tiene private set
            typeof(Empleado).GetProperty("Id")
                .SetValue(e, reader.GetInt32(0), null);

            e.Nombre = reader.GetString(1);
            e.Apodo = reader.IsDBNull(2) ? null : reader.GetString(2);
            e.Cedula = reader.GetString(3);
            e.Telefono = reader.IsDBNull(4) ? null : reader.GetString(4);
            e.Rol = (RolEmpleado)reader.GetInt32(5);
            e.SalarioBase = reader.GetDecimal(6);
            e.PorcentajeComision = reader.GetDecimal(7);
            e.VentasMes = reader.GetDecimal(8);
            e.Activo = reader.GetBoolean(9);
            return e;
        }
    }
}