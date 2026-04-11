using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstClientes.Items.Clear();
            foreach (Cliente c in Form1.Clientes)
                lstClientes.Items.Add(c);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevo = new Cliente(txtNombre.Text, txtTelefono.Text);
                ResultadoValidacion resultado = Validador.Validar(nuevo);

                if (!resultado.EsValido)
                {
                    MessageBox.Show(string.Join("\n", resultado.Errores),
                        "Errores de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Guarda en base de datos y recarga la lista
                int id = Form1.GuardarCliente(nuevo);
                ActualizarLista();
                txtNombre.Text = "";
                txtTelefono.Text = "";
                MessageBox.Show("Cliente guardado con ID: " + id, "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = txtBuscar.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(termino))
            {
                ActualizarLista();
                return;
            }

            lstClientes.Items.Clear();
            foreach (Cliente c in Form1.Clientes)
            {
                if (c.Nombre.ToLower().Contains(termino) ||
                    c.Telefono.Contains(termino))
                    lstClientes.Items.Add(c);
            }

            if (lstClientes.Items.Count == 0)
                MessageBox.Show("No se encontraron clientes.", "Busqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            Cliente c = lstClientes.SelectedItem as Cliente;
            if (c == null)
            {
                MessageBox.Show("Selecciona un cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("══════════════════════════");
            sb.AppendLine("  INFORMACION DEL CLIENTE");
            sb.AppendLine("══════════════════════════");
            sb.AppendLine(string.Format("ID:       {0}", c.Id));
            sb.AppendLine(string.Format("Nombre:   {0}", c.Nombre));
            sb.AppendLine(string.Format("Telefono: {0}", c.TelefonoFormateado()));
            sb.AppendLine(string.Format("Tipo:     {0}", c.Tipo));
            sb.AppendLine(string.Format("Visitas:  {0}", c.Visitas));
            sb.AppendLine(string.Format("Descuento:{0:P0}", c.ObtenerDescuento()));
            sb.AppendLine("══════════════════════════");

            txtInfo.Text = sb.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            ActualizarLista();
        }
    }
}