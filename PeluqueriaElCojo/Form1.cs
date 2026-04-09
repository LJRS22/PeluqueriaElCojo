using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Empleado> _empleados = new List<Empleado>();
        private List<Producto> _productos = new List<Producto>();
        private List<Servicio> _serviciosActuales = new List<Servicio>();
        private Cliente _clienteSeleccionado = null;

        public Form1()
        {
            InitializeComponent();
            CargarDatosDePrueba();
        }

        private void CargarDatosDePrueba()
        {
            Cliente c1 = new Cliente("Pedro Sanchez", "8095551111");
            c1.RegistrarVisita(); c1.RegistrarVisita(); c1.RegistrarVisita();
            _clientes.Add(c1);

            Cliente c2 = new Cliente("Luis Rodriguez", "8295552222");
            for (int i = 0; i < 10; i++) c2.RegistrarVisita();
            _clientes.Add(c2);

            _clientes.Add(new Cliente("Ana Martinez", "8495553333"));

            Empleado e1 = new Empleado();
            e1.Nombre = "Rafael Martinez";
            e1.Apodo = "El Cojo";
            e1.Cedula = "00112345678";
            e1.Telefono = "8095551234";
            e1.SalarioBase = 25000;
            e1.PorcentajeComision = 15;
            e1.VentasMes = 45000;
            _empleados.Add(e1);

            Empleado e2 = new Empleado();
            e2.Nombre = "Juan Perez";
            e2.Apodo = "Juancho";
            e2.Cedula = "00176543210";
            e2.Telefono = "8295554321";
            e2.SalarioBase = 20000;
            e2.PorcentajeComision = 10;
            e2.VentasMes = 32000;
            _empleados.Add(e2);

            Producto p1 = new Producto();
            p1.Codigo = "GEL001";
            p1.Nombre = "Gel Fijador Fuerte";
            p1.Categoria = CategoriaProducto.GelYCera;
            p1.Precio = 150;
            p1.Costo = 80;
            p1.Stock = 3;
            p1.StockMinimo = 5;
            _productos.Add(p1);

            Producto p2 = new Producto();
            p2.Codigo = "SHA001";
            p2.Nombre = "Shampoo Anticaspa";
            p2.Categoria = CategoriaProducto.Shampoo;
            p2.Precio = 180;
            p2.Costo = 90;
            p2.Stock = 15;
            p2.StockMinimo = 5;
            _productos.Add(p2);

            ActualizarListaClientes();
        }

        private void ActualizarListaClientes()
        {
            lstClientes.Items.Clear();
            foreach (Cliente c in _clientes)
                lstClientes.Items.Add(c);
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clienteSeleccionado = lstClientes.SelectedItem as Cliente;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevo = new Cliente(txtNombre.Text, txtTelefono.Text);

                ResultadoValidacion resultado = Validador.Validar(nuevo);
                if (!resultado.EsValido)
                {
                    string errores = string.Join("\n", resultado.Errores);
                    MessageBox.Show(errores, "Errores de validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _clientes.Add(nuevo);
                ActualizarListaClientes();
                txtNombre.Text = "";
                txtTelefono.Text = "";

                MessageBox.Show("Cliente agregado correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (_clienteSeleccionado == null)
            {
                MessageBox.Show("Selecciona un cliente de la lista.",
                    "Cliente requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _serviciosActuales.Clear();

            if (chkCorteNormal.Checked)
                _serviciosActuales.Add(new CorteNormal());
            if (chkDegradado.Checked)
                _serviciosActuales.Add(new Degradado((int)numNivel.Value));
            if (chkAfeitado.Checked)
                _serviciosActuales.Add(new Afeitado(chkToalla.Checked));
            if (chkCejas.Checked)
                _serviciosActuales.Add(new CorteCejas());

            if (_serviciosActuales.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un servicio.",
                    "Servicio requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _clienteSeleccionado.RegistrarVisita();
            txtRecibo.Text = GenerarRecibo();
            lblTotal.Text = string.Format("TOTAL: RD${0:N2}", CalcularTotal());
            ActualizarListaClientes();
        }

        private decimal CalcularTotal()
        {
            decimal subtotal = 0;
            foreach (Servicio s in _serviciosActuales)
                subtotal += s.CalcularPrecio();

            decimal descuento = _clienteSeleccionado.ObtenerDescuento();
            return subtotal * (1 - descuento) * 1.18m;
        }

        private string GenerarRecibo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("╔═══════════════════════════════════╗");
            sb.AppendLine("║    PELUQUERIA EL COJO             ║");
            sb.AppendLine("║    Villa Mella, Sto. Domingo      ║");
            sb.AppendLine("╠═══════════════════════════════════╣");
            sb.AppendLine(string.Format("║ Cliente: {0,-24}║", _clienteSeleccionado.Nombre));
            sb.AppendLine(string.Format("║ Tipo:    {0,-24}║", _clienteSeleccionado.Tipo));
            sb.AppendLine(string.Format("║ Tel:     {0,-24}║", _clienteSeleccionado.TelefonoFormateado()));
            sb.AppendLine("╠═══════════════════════════════════╣");

            decimal subtotal = 0;
            foreach (Servicio s in _serviciosActuales)
            {
                sb.AppendLine(string.Format("║ {0,-33}║", s.GenerarLineaRecibo()));
                subtotal += s.CalcularPrecio();
            }

            decimal descPct = _clienteSeleccionado.ObtenerDescuento();
            decimal conDescuento = subtotal * (1 - descPct);

            sb.AppendLine("╠═══════════════════════════════════╣");
            sb.AppendLine(string.Format("║ Subtotal:        RD${0,13:N0} ║", subtotal));

            if (descPct > 0)
                sb.AppendLine(string.Format("║ Descuento {0,3:P0}:  -RD${1,12:N0} ║",
                    descPct, subtotal * descPct));

            sb.AppendLine(string.Format("║ ITBIS 18%:        RD${0,12:N0} ║", conDescuento * 0.18m));
            sb.AppendLine("╠═══════════════════════════════════╣");
            sb.AppendLine(string.Format("║ TOTAL:            RD${0,12:N0} ║", conDescuento * 1.18m));
            sb.AppendLine("╚═══════════════════════════════════╝");
            sb.AppendLine("      Gracias por su visita!");
            sb.AppendLine(string.Format("      {0:dd/MM/yyyy hh:mm tt}", DateTime.Now));

            return sb.ToString();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtRecibo_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void chkAfeitado_CheckedChanged(object sender, EventArgs e) { }
        private void chkCejas_CheckedChanged(object sender, EventArgs e) { }
    }
}