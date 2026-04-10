using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstProductos.Items.Clear();
            foreach (Producto p in Form1.Productos)
                lstProductos.Items.Add(p);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevo = new Producto();
                nuevo.Codigo = txtCodigo.Text.ToUpper().Trim();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Precio = (decimal)numPrecio.Value;
                nuevo.Costo = (decimal)numCosto.Value;
                nuevo.Stock = (int)numStock.Value;
                nuevo.StockMinimo = (int)numStockMin.Value;

                // IEquatable en accion: Contains usa el Equals que definimos
                // compara por codigo sin importar mayusculas
                if (Form1.Productos.Contains(nuevo))
                {
                    MessageBox.Show(
                        string.Format("Ya existe un producto con el codigo {0}.", nuevo.Codigo),
                        "Duplicado detectado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validamos con Reflection automaticamente
                ResultadoValidacion resultado = Validador.Validar(nuevo);
                if (!resultado.EsValido)
                {
                    MessageBox.Show(string.Join("\n", resultado.Errores),
                        "Errores de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Form1.Productos.Add(nuevo);
                ActualizarLista();
                LimpiarCampos();
                MessageBox.Show("Producto agregado correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlertaStock_Click(object sender, EventArgs e)
        {
            // Genera reporte de productos con stock bajo
            string reporte = GeneradorReportes.GenerarAlertaStock(Form1.Productos);
            txtReporte.Text = reporte;
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            Producto p = lstProductos.SelectedItem as Producto;
            if (p == null)
            {
                MessageBox.Show("Selecciona un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("══════════════════════════════");
            sb.AppendLine("  INFORMACION DEL PRODUCTO");
            sb.AppendLine("══════════════════════════════");
            sb.AppendLine(string.Format("Codigo:    {0}", p.Codigo));
            sb.AppendLine(string.Format("Nombre:    {0}", p.Nombre));
            sb.AppendLine(string.Format("Categoria: {0}", p.Categoria));
            sb.AppendLine(string.Format("Precio:    RD${0:N0}", p.Precio));
            sb.AppendLine(string.Format("Costo:     RD${0:N0}", p.Costo));
            sb.AppendLine(string.Format("Ganancia:  RD${0:N0}", p.Ganancia));
            sb.AppendLine(string.Format("Margen:    {0:N1}%", p.MargenPorcentaje));
            sb.AppendLine(string.Format("Stock:     {0}", p.Stock));
            sb.AppendLine(string.Format("Stock Min: {0}", p.StockMinimo));
            sb.AppendLine(string.Format("Reponer:   {0}", p.RequiereReposicion ? "SI" : "NO"));
            sb.AppendLine(string.Format("Val.Inv:   RD${0:N0}", p.ValorInventario));
            sb.AppendLine("══════════════════════════════");

            txtReporte.Text = sb.ToString();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            // Usa Reflection para generar tabla con cualquier lista
            string reporte = GeneradorReportes.GenerarTabla(Form1.Productos, "INVENTARIO COMPLETO");
            txtReporte.Text = reporte;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            numPrecio.Value = 1;
            numCosto.Value = 1;
            numStock.Value = 0;
            numStockMin.Value = 5;
        }
    }
}