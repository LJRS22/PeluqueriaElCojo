using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Carpeta de destino del backup
                string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fecha = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
                string archivo = Path.Combine(carpeta, string.Format("Backup_PeluqueriaElCojo_{0}.txt", fecha));

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("══════════════════════════════════════════════════════");
                sb.AppendLine("         BACKUP - PELUQUERIA EL COJO");
                sb.AppendLine(string.Format("         Fecha: {0:dd/MM/yyyy HH:mm}", DateTime.Now));
                sb.AppendLine(string.Format("         Usuario: {0}", FormLogin.UsuarioActual.NombreUsuario));
                sb.AppendLine("══════════════════════════════════════════════════════");
                sb.AppendLine();

                // Backup de Clientes
                sb.AppendLine("-- CLIENTES --");
                sb.AppendLine(string.Format("Total: {0} clientes", Form1.Clientes.Count));
                sb.AppendLine();
                foreach (Cliente c in Form1.Clientes)
                {
                    sb.AppendLine(string.Format("INSERT INTO Clientes (Nombre, Telefono, Tipo, Visitas) VALUES ('{0}', '{1}', {2}, {3});",
                        c.Nombre, c.Telefono, (int)c.Tipo, c.Visitas));
                }
                sb.AppendLine();

                // Backup de Empleados
                sb.AppendLine("-- EMPLEADOS --");
                sb.AppendLine(string.Format("Total: {0} empleados", Form1.Empleados.Count));
                sb.AppendLine();
                foreach (Empleado emp in Form1.Empleados)
                {
                    sb.AppendLine(string.Format("INSERT INTO Empleados (Nombre, Apodo, Cedula, Telefono, Rol, SalarioBase, PorcentajeComision, VentasMes) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, {7});",
                        emp.Nombre,
                        emp.Apodo ?? "",
                        emp.Cedula,
                        emp.Telefono ?? "",
                        (int)emp.Rol,
                        emp.SalarioBase,
                        emp.PorcentajeComision,
                        emp.VentasMes));
                }
                sb.AppendLine();

                // Backup de Productos
                sb.AppendLine("-- PRODUCTOS --");
                sb.AppendLine(string.Format("Total: {0} productos", Form1.Productos.Count));
                sb.AppendLine();
                foreach (Producto p in Form1.Productos)
                {
                    sb.AppendLine(string.Format("INSERT INTO Productos (Codigo, Nombre, Categoria, Precio, Costo, Stock, StockMinimo) VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, {6});",
                        p.Codigo, p.Nombre, (int)p.Categoria,
                        p.Precio, p.Costo, p.Stock, p.StockMinimo));
                }
                sb.AppendLine();
                sb.AppendLine("══════════════════════════════════════════════════════");
                sb.AppendLine("                  FIN DEL BACKUP");
                sb.AppendLine("══════════════════════════════════════════════════════");

                // Guardar el archivo en el escritorio
                File.WriteAllText(archivo, sb.ToString(), Encoding.UTF8);

                txtResultado.Text = sb.ToString();
                MessageBox.Show(
                    "Backup generado correctamente en el Escritorio:\n" + archivo,
                    "Backup exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar backup: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}