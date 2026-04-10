using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo
{
    public partial class FormFacturacion : Form
    {
        // Lista de servicios seleccionados para la factura actual
        private List<Servicio> _serviciosActuales = new List<Servicio>();

        public FormFacturacion()
        {
            InitializeComponent();
            CargarClientes();
            CargarEmpleados();
        }

        private void CargarClientes()
        {
            cmbCliente.Items.Clear();
            foreach (Cliente c in Form1.Clientes)
                cmbCliente.Items.Add(c);

            if (cmbCliente.Items.Count > 0)
                cmbCliente.SelectedIndex = 0;
        }

        private void CargarEmpleados()
        {
            cmbEmpleado.Items.Clear();
            foreach (Empleado e in Form1.Empleados)
            {
                if (e.Rol == RolEmpleado.Barbero && e.Activo)
                    cmbEmpleado.Items.Add(e);
            }

            if (cmbEmpleado.Items.Count > 0)
                cmbEmpleado.SelectedIndex = 0;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            // Verificamos que haya cliente y barbero seleccionados
            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un barbero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construimos la lista de servicios usando polimorfismo
            // cada objeto es de un tipo diferente pero todos son Servicio
            _serviciosActuales.Clear();

            if (chkCorteNormal.Checked)
                _serviciosActuales.Add(new CorteNormal());
            if (chkDegradado.Checked)
                _serviciosActuales.Add(new Degradado((int)numNivel.Value));
            if (chkAfeitado.Checked)
                _serviciosActuales.Add(new Afeitado(chkToalla.Checked));
            if (chkCejas.Checked)
                _serviciosActuales.Add(new CorteCejas());
            if (chkCombo.Checked)
                _serviciosActuales.Add(new ComboCompleto());

            if (_serviciosActuales.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un servicio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = cmbCliente.SelectedItem as Cliente;
            Empleado barbero = cmbEmpleado.SelectedItem as Empleado;

            // Registramos la visita del cliente
            cliente.RegistrarVisita();

            // Calculamos el total de ventas para el barbero
            decimal subtotal = 0;
            foreach (Servicio s in _serviciosActuales)
                subtotal += s.CalcularPrecio();

            // Actualizamos las ventas del barbero del mes
            barbero.VentasMes += subtotal;

            // Generamos y mostramos el recibo
            txtRecibo.Text = GenerarRecibo(cliente, barbero);
            lblTotal.Text = string.Format("TOTAL: RD${0:N2}", CalcularTotal(cliente));
        }

        private decimal CalcularTotal(Cliente cliente)
        {
            decimal subtotal = 0;

            // POLIMORFISMO: cada servicio calcula su propio precio
            foreach (Servicio s in _serviciosActuales)
                subtotal += s.CalcularPrecio();

            decimal descuento = cliente.ObtenerDescuento();
            return subtotal * (1 - descuento) * 1.18m;
        }

        private string GenerarRecibo(Cliente cliente, Empleado barbero)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("╔═══════════════════════════════════╗");
            sb.AppendLine("║    PELUQUERIA EL COJO             ║");
            sb.AppendLine("║    Villa Mella, Sto. Domingo      ║");
            sb.AppendLine("╠═══════════════════════════════════╣");
            sb.AppendLine(string.Format("║ Cliente: {0,-24}║", cliente.Nombre));
            sb.AppendLine(string.Format("║ Tipo:    {0,-24}║", cliente.Tipo));
            sb.AppendLine(string.Format("║ Barbero: {0,-24}║",
                string.IsNullOrEmpty(barbero.Apodo) ? barbero.Nombre : barbero.Apodo));
            sb.AppendLine("╠═══════════════════════════════════╣");

            decimal subtotal = 0;

            // POLIMORFISMO: cada servicio genera su propia linea
            foreach (Servicio s in _serviciosActuales)
            {
                sb.AppendLine(string.Format("║ {0,-33}║", s.GenerarLineaRecibo()));
                subtotal += s.CalcularPrecio();
            }

            decimal descPct = cliente.ObtenerDescuento();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chkCorteNormal.Checked = false;
            chkDegradado.Checked = false;
            chkAfeitado.Checked = false;
            chkToalla.Checked = false;
            chkCejas.Checked = false;
            chkCombo.Checked = false;
            numNivel.Value = 1;
            txtRecibo.Text = "";
            lblTotal.Text = "TOTAL: RD$0.00";
            _serviciosActuales.Clear();
        }
    }
}