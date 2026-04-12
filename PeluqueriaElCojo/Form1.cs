using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Datos;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<Empleado> Empleados = new List<Empleado>();
        public static List<Producto> Productos = new List<Producto>();

        private static ClienteRepository _clienteRepo = new ClienteRepository();
        private static EmpleadoRepository _empleadoRepo = new EmpleadoRepository();
        private static ProductoRepository _productoRepo = new ProductoRepository();

        public Form1()
        {
            InitializeComponent();
            ProbarConexion();
            CargarDatosDesdeDB();

            if (FormLogin.UsuarioActual != null)
            {
                this.Text = string.Format("Peluqueria El Cojo - {0} ({1})",
                    FormLogin.UsuarioActual.NombreUsuario,
                    FormLogin.UsuarioActual.Rol);
            }

            AplicarPrivilegios();
        }

        private void AplicarPrivilegios()
        {
            if (FormLogin.UsuarioActual == null) return;

            switch (FormLogin.UsuarioActual.Rol)
            {
                case RolSistema.Administrador:
                    btnClientes.Enabled = true;
                    btnEmpleados.Enabled = true;
                    btnInventario.Enabled = true;
                    btnFacturacion.Enabled = true;
                    btnBackup.Enabled = true;
                    break;

                case RolSistema.Recepcionista:
                    btnClientes.Enabled = true;
                    btnEmpleados.Enabled = false;
                    btnInventario.Enabled = true;
                    btnFacturacion.Enabled = true;
                    btnBackup.Enabled = false;
                    btnEmpleados.Text = "Empleados (Sin acceso)";
                    btnBackup.Text = "Backup (Sin acceso)";
                    break;

                case RolSistema.Barbero:
                    btnClientes.Enabled = true;
                    btnEmpleados.Enabled = false;
                    btnInventario.Enabled = false;
                    btnFacturacion.Enabled = true;
                    btnBackup.Enabled = false;
                    btnEmpleados.Text = "Empleados (Sin acceso)";
                    btnInventario.Text = "Inventario (Sin acceso)";
                    btnBackup.Text = "Backup (Sin acceso)";
                    break;
            }
        }

        private void ProbarConexion()
        {
            string mensaje;
            if (!Conexion.ProbarConexion(out mensaje))
            {
                MessageBox.Show(
                    "No se pudo conectar a la base de datos.\n\n" + mensaje,
                    "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CargarDatosDesdeDB()
        {
            try
            {
                Clientes = _clienteRepo.ObtenerTodos();
                Empleados = _empleadoRepo.ObtenerTodos();
                Productos = _productoRepo.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int GuardarCliente(Cliente c)
        {
            int id = _clienteRepo.Insertar(c);
            CargarDatosDesdeDB();
            return id;
        }

        public static bool ActualizarCliente(Cliente c)
        {
            bool ok = _clienteRepo.Actualizar(c);
            CargarDatosDesdeDB();
            return ok;
        }

        public static int GuardarEmpleado(Empleado e)
        {
            int id = _empleadoRepo.Insertar(e);
            CargarDatosDesdeDB();
            return id;
        }

        public static bool ActualizarVentasEmpleado(int empleadoId, decimal monto)
        {
            bool ok = _empleadoRepo.ActualizarVentas(empleadoId, monto);
            CargarDatosDesdeDB();
            return ok;
        }

        public static int GuardarProducto(Producto p)
        {
            int id = _productoRepo.Insertar(p);
            CargarDatosDesdeDB();
            return id;
        }

        public static bool ExisteCodigoProducto(string codigo)
        {
            return _productoRepo.ExisteCodigo(codigo);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes f = new FormClientes();
            f.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (FormLogin.UsuarioActual.Rol != RolSistema.Administrador)
            {
                MessageBox.Show("Solo el Administrador puede gestionar empleados.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormEmpleados f = new FormEmpleados();
            f.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (FormLogin.UsuarioActual.Rol == RolSistema.Barbero)
            {
                MessageBox.Show("Solo Administrador y Recepcionista pueden ver el inventario.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormInventario f = new FormInventario();
            f.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FormFacturacion f = new FormFacturacion();
            f.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (FormLogin.UsuarioActual.Rol != RolSistema.Administrador)
            {
                MessageBox.Show("Solo el Administrador puede generar backups.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormBackup f = new FormBackup();
            f.ShowDialog();
        }
    }
}