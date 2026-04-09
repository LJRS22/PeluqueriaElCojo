using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Utilidades
{
    // Generador dinamico de reportes en formato tabla de texto
    // usa Reflection para leer las propiedades de cualquier objeto
    // sin necesidad de saber de antemano que tipo de objeto es
    public static class GeneradorReportes
    {
        // Genera una tabla de texto para cualquier lista de objetos
        // T puede ser Cliente, Empleado, Producto o cualquier otra clase
        // Reflection se encarga de descubrir las columnas automaticamente
        public static string GenerarTabla<T>(List<T> lista, string titulo)
        {
            if (lista == null || lista.Count == 0)
                return "No hay datos para mostrar.";

            StringBuilder sb = new StringBuilder();

            // REFLECTION: obtenemos las propiedades del tipo T
            Type tipo = typeof(T);
            PropertyInfo[] propiedades = tipo.GetProperties();

            // Calculamos el ancho de cada columna segun el nombre de la propiedad
            int anchoCols = 15;
            int anchoTotal = (propiedades.Length * (anchoCols + 1)) + 1;

            // Linea superior
            sb.AppendLine("+" + new string('-', anchoTotal - 2) + "+");

            // Titulo centrado
            sb.AppendLine("|" + Centrar(titulo, anchoTotal - 2) + "|");
            sb.AppendLine("+" + new string('-', anchoTotal - 2) + "+");

            // Encabezados de columnas usando los nombres de las propiedades
            sb.Append("|");
            foreach (PropertyInfo prop in propiedades)
            {
                sb.Append(Ajustar(prop.Name, anchoCols) + "|");
            }
            sb.AppendLine();
            sb.AppendLine("+" + new string('-', anchoTotal - 2) + "+");

            // Filas de datos
            // REFLECTION: leemos el valor de cada propiedad en cada objeto
            foreach (T item in lista)
            {
                sb.Append("|");
                foreach (PropertyInfo prop in propiedades)
                {
                    // Obtenemos el valor actual de esta propiedad en este objeto
                    object valor = prop.GetValue(item);
                    string texto = valor != null ? valor.ToString() : "";
                    sb.Append(Ajustar(texto, anchoCols) + "|");
                }
                sb.AppendLine();
            }

            sb.AppendLine("+" + new string('-', anchoTotal - 2) + "+");
            sb.AppendLine(string.Format("Total de registros: {0}", lista.Count));

            return sb.ToString();
        }

        // Genera un reporte especifico de ranking de empleados por ventas
        // usa IComparable que implementamos en Empleado para ordenar la lista
        public static string GenerarRankingEmpleados(
            List<PeluqueriaElCojo.Modelos.Empleado> empleados)
        {
            if (empleados == null || empleados.Count == 0)
                return "No hay empleados registrados.";

            // Filtramos solo barberos activos
            List<PeluqueriaElCojo.Modelos.Empleado> barberos =
                new List<PeluqueriaElCojo.Modelos.Empleado>();

            foreach (var e in empleados)
            {
                if (e.Rol == PeluqueriaElCojo.Modelos.RolEmpleado.Barbero && e.Activo)
                    barberos.Add(e);
            }

            if (barberos.Count == 0)
                return "No hay barberos activos.";

            // Sort usa automaticamente el CompareTo que definimos en Empleado
            // ordena de mayor a menor por ventas del mes
            barberos.Sort();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("╔══════════════════════════════════════════╗");
            sb.AppendLine("║     RANKING DE BARBEROS DEL MES          ║");
            sb.AppendLine("╠══════════════════════════════════════════╣");
            sb.AppendLine("║ #  │ Nombre           │ Ventas  │ Comis  ║");
            sb.AppendLine("╠════╪══════════════════╪═════════╪════════╣");

            int posicion = 1;
            foreach (var b in barberos)
            {
                string nombre = string.IsNullOrEmpty(b.Apodo) ? b.Nombre : b.Apodo;
                if (nombre.Length > 16) nombre = nombre.Substring(0, 16);

                sb.AppendLine(string.Format(
                    "║ {0}  │ {1,-16} │ {2,7:N0} │ {3,6:N0} ║",
                    posicion, nombre, b.VentasMes, b.CalcularComision()));
                posicion++;
            }

            sb.AppendLine("╚══════════════════════════════════════════╝");
            return sb.ToString();
        }

        // Genera alerta de productos con stock bajo
        public static string GenerarAlertaStock(
            List<PeluqueriaElCojo.Modelos.Producto> productos)
        {
            if (productos == null || productos.Count == 0)
                return "No hay productos registrados.";

            List<PeluqueriaElCojo.Modelos.Producto> bajoStock =
                new List<PeluqueriaElCojo.Modelos.Producto>();

            foreach (var p in productos)
            {
                if (p.RequiereReposicion && p.Activo)
                    bajoStock.Add(p);
            }

            if (bajoStock.Count == 0)
                return "Todos los productos tienen stock suficiente.";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("╔══════════════════════════════════════════╗");
            sb.AppendLine("║     PRODUCTOS CON BAJO STOCK             ║");
            sb.AppendLine("╠══════════════════════════════════════════╣");
            sb.AppendLine("║ Codigo     │ Nombre           │ Stock    ║");
            sb.AppendLine("╠════════════╪══════════════════╪══════════╣");

            foreach (var p in bajoStock)
            {
                string nombre = p.Nombre;
                if (nombre.Length > 16) nombre = nombre.Substring(0, 16);
                string codigo = p.Codigo;
                if (codigo.Length > 10) codigo = codigo.Substring(0, 10);

                sb.AppendLine(string.Format(
                    "║ {0,-10} │ {1,-16} │ {2,8} ║",
                    codigo, nombre, p.Stock));
            }

            sb.AppendLine("╚══════════════════════════════════════════╝");
            sb.AppendLine(string.Format("Total productos con bajo stock: {0}",
                bajoStock.Count));

            return sb.ToString();
        }

        // ── METODOS PRIVADOS DE FORMATO ───────────────────────────────────────

        // Ajusta un texto al ancho indicado, cortando si es muy largo
        private static string Ajustar(string texto, int ancho)
        {
            if (texto == null) texto = "";
            if (texto.Length > ancho) texto = texto.Substring(0, ancho);
            return texto.PadRight(ancho);
        }

        // Centra un texto dentro de un ancho dado
        private static string Centrar(string texto, int ancho)
        {
            if (texto.Length >= ancho) return texto;
            int espacios = (ancho - texto.Length) / 2;
            return texto.PadLeft(espacios + texto.Length).PadRight(ancho);
        }
    }
}