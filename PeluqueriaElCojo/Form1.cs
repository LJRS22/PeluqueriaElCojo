using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Datos;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {
        // Listas estaticas compartidas entre todos los formularios
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<Empleado> Empleados = new List<Empleado>();
        public static List<Producto> Productos = new List<Producto>();

        // Repositorios para acceder a la base de datos
        private static ClienteRepository _clienteRepo = new ClienteRepository();
        private static EmpleadoRepository _empleadoRepo = new EmpleadoRepository();
        private static ProductoRepository _productoRepo = new ProductoRepository();

        public Form1()
        {
            InitializeComponent();
            ProbarConexion();
            CargarDatosDesdeDB();
        }

        // Verifica que la conexion a SQL Server funcione al arrancar
        private void ProbarConexion()
        {
            string mensaje;
            if (!Conexion.ProbarConexion(out mensaje))
            {
                MessageBox.Show(
                    "No se pudo conectar a la base de datos.\n\n" + mensaje +
                    "\n\nVerifica que SQL Server este corriendo.",
                    "Error de conexion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Carga todos los datos desde SQL Server al iniciar
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

        // Guarda un cliente nuevo en BD y recarga las listas
        public static int GuardarCliente(Cliente c)
        {
            int id = _clienteRepo.Insertar(c);
            CargarDatosDesdeDB();
            return id;
        }

        // Actualiza los datos de un cliente existente en BD
        public static bool ActualizarCliente(Cliente c)
        {
            bool ok = _clienteRepo.Actualizar(c);
            CargarDatosDesdeDB();
            return ok;
        }

        // Guarda un empleado nuevo en BD y recarga las listas
        public static int GuardarEmpleado(Empleado e)
        {
            int id = _empleadoRepo.Insertar(e);
            CargarDatosDesdeDB();
            return id;
        }

        // Suma el monto de ventas al barbero en BD
        public static bool ActualizarVentasEmpleado(int empleadoId, decimal monto)
        {
            bool ok = _empleadoRepo.ActualizarVentas(empleadoId, monto);
            CargarDatosDesdeDB();
            return ok;
        }

        // Guarda un producto nuevo en BD y recarga las listas
        public static int GuardarProducto(Producto p)
        {
            int id = _productoRepo.Insertar(p);
            CargarDatosDesdeDB();
            return id;
        }

        // Verifica si ya existe un producto con ese codigo en BD
        public static bool ExisteCodigoProducto(string codigo)
        {
            return _productoRepo.ExisteCodigo(codigo);
        }

        // Botones del menu principal
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes f = new FormClientes();
            f.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados f = new FormEmpleados();
            f.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventario f = new FormInventario();
            f.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FormFacturacion f = new FormFacturacion();
            f.ShowDialog();
        }
    }
}