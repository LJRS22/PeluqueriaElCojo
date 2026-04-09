using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {
        // Listas compartidas entre todos los formularios
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<Empleado> Empleados = new List<Empleado>();
        public static List<Producto> Productos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
            CargarDatosDePrueba();
        }

        // Carga datos iniciales para que el sistema no arranque vacio
        private void CargarDatosDePrueba()
        {
            // Clientes de prueba
            Cliente c1 = new Cliente("Pedro Sanchez", "8095551111");
            c1.RegistrarVisita(); c1.RegistrarVisita(); c1.RegistrarVisita();
            Clientes.Add(c1);

            Cliente c2 = new Cliente("Luis Rodriguez", "8295552222");
            for (int i = 0; i < 10; i++) c2.RegistrarVisita();
            Clientes.Add(c2);

            Clientes.Add(new Cliente("Ana Martinez", "8495553333"));

            // Empleados de prueba
            Empleado e1 = new Empleado();
            e1.Nombre = "Rafael Martinez";
            e1.Apodo = "El Cojo";
            e1.Cedula = "00112345678";
            e1.Telefono = "8095551234";
            e1.SalarioBase = 25000;
            e1.PorcentajeComision = 15;
            e1.VentasMes = 45000;
            Empleados.Add(e1);

            Empleado e2 = new Empleado();
            e2.Nombre = "Juan Perez";
            e2.Apodo = "Juancho";
            e2.Cedula = "00176543210";
            e2.Telefono = "8295554321";
            e2.SalarioBase = 20000;
            e2.PorcentajeComision = 10;
            e2.VentasMes = 32000;
            Empleados.Add(e2);

            // Productos de prueba
            Producto p1 = new Producto();
            p1.Codigo = "GEL001";
            p1.Nombre = "Gel Fijador Fuerte";
            p1.Categoria = CategoriaProducto.GelYCera;
            p1.Precio = 150;
            p1.Costo = 80;
            p1.Stock = 3;
            p1.StockMinimo = 5;
            Productos.Add(p1);

            Producto p2 = new Producto();
            p2.Codigo = "SHA001";
            p2.Nombre = "Shampoo Anticaspa";
            p2.Categoria = CategoriaProducto.Shampoo;
            p2.Precio = 180;
            p2.Costo = 90;
            p2.Stock = 15;
            p2.StockMinimo = 5;
            Productos.Add(p2);
        }

        // Abre el formulario de clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes f = new FormClientes();
            f.ShowDialog();
        }

        // Abre el formulario de empleados
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados f = new FormEmpleados();
            f.ShowDialog();
        }

        // Abre el formulario de inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventario f = new FormInventario();
            f.ShowDialog();
        }

        // Abre el formulario de facturacion
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FormFacturacion f = new FormFacturacion();
            f.ShowDialog();
        }
    }
}