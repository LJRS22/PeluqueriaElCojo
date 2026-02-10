using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Servicio> _servicios = new List<Servicio>();
        private Cliente _clienteActual = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente(txtNombre.Text, txtTelefono.Text);

                _clientes.Add(c);
                lstClientes.Items.Add(c);

                txtNombre.Clear();
                txtTelefono.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
                _clienteActual = _clientes[lstClientes.SelectedIndex];
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (_clienteActual == null)
            {
                MessageBox.Show("Selecciona cliente");
                return;
            }

            _servicios.Clear();

            if (chkCorteNormal.Checked)
                _servicios.Add(new CorteNormal());

            if (chkDegradado.Checked)
                _servicios.Add(new Degradado((int)numNivel.Value));

            if (chkAfeitado.Checked)
                _servicios.Add(new Afeitado(chkToalla.Checked));

            if (chkCejas.Checked)
                _servicios.Add(new CorteCejas());

            if (_servicios.Count == 0)
            {
                MessageBox.Show("Selecciona servicios");
                return;
            }

            _clienteActual.RegistrarVisita();

            lstClientes.Items[lstClientes.SelectedIndex] = _clienteActual;

            txtRecibo.Text = GenerarRecibo();

            lblTotal.Text = string.Format("TOTAL: RD${0:N2}", CalcularTotal());

            LimpiarChecks();
        }

        private decimal CalcularTotal()
        {
            decimal sub = 0;

            foreach (Servicio s in _servicios)
                sub += s.CalcularPrecio();

            return sub * (1 - _clienteActual.ObtenerDescuento()) * 1.18m;
        }

        private string GenerarRecibo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("╔═══════════════════════════════╗");
            sb.AppendLine("║    PELUQUERÍA EL COJO         ║");
            sb.AppendLine("║    Villa Mella, Sto. Domingo  ║");
            sb.AppendLine("╠═══════════════════════════════╣");

            sb.AppendLine(string.Format("║ Cliente: {0,-20}║", _clienteActual.Nombre));
            sb.AppendLine(string.Format("║ Tipo: {0,-23}║", _clienteActual.Tipo));

            sb.AppendLine("╠═══════════════════════════════╣");

            decimal sub = 0;

            foreach (Servicio s in _servicios)
            {
                sb.AppendLine(string.Format("║  {0,-27}║", s.GenerarLineaRecibo()));
                sub += s.CalcularPrecio();
            }

            sb.AppendLine("╠═══════════════════════════════╣");

            sb.AppendLine(string.Format("║ Subtotal:        RD${0,8:N0} ║", sub));

            decimal desc = _clienteActual.ObtenerDescuento();

            if (desc > 0)
            {
                sb.AppendLine(string.Format(
                    "║ Descuento ({0}%): -RD${1,6:N0} ║",
                    desc * 100,
                    sub * desc));
            }

            decimal baseI = sub * (1 - desc);

            sb.AppendLine(string.Format("║ ITBIS (18%):      RD${0,7:N0} ║", baseI * 0.18m));

            sb.AppendLine("╠═══════════════════════════════╣");

            sb.AppendLine(string.Format("║ TOTAL:           RD${0,8:N0} ║", baseI * 1.18m));

            sb.AppendLine("╚═══════════════════════════════╝");
            sb.AppendLine("      ¡Gracias por su visita!");

            return sb.ToString();
        }

        private void LimpiarChecks()
        {
            chkCorteNormal.Checked = false;
            chkDegradado.Checked = false;
            chkAfeitado.Checked = false;
            chkToalla.Checked = false;
            chkCejas.Checked = false;

            numNivel.Value = 1;
        }

        private void chkCejas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAfeitado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
