namespace PeluqueriaElCojo
{
    partial class FormInventario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.numCosto = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numStockMin = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAlertaStock = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMin)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 120, 0);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(860, 30);
            this.lblTitulo.Text = "Control de Inventario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblCodigo
            this.lblCodigo.Location = new System.Drawing.Point(12, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 22);
            this.lblCodigo.Text = "Codigo:";
            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(12, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.Text = "Nombre:";
            // lblPrecio
            this.lblPrecio.Location = new System.Drawing.Point(12, 115);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(80, 22);
            this.lblPrecio.Text = "Precio RD$:";
            // lblCosto
            this.lblCosto.Location = new System.Drawing.Point(12, 145);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(80, 22);
            this.lblCosto.Text = "Costo RD$:";
            // lblStock
            this.lblStock.Location = new System.Drawing.Point(12, 175);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(80, 22);
            this.lblStock.Text = "Stock:";
            // lblStockMin
            this.lblStockMin.Location = new System.Drawing.Point(12, 205);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(80, 22);
            this.lblStockMin.Text = "Stock Min:";
            // txtCodigo
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(100, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 22);
            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(100, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            // numPrecio
            this.numPrecio.Location = new System.Drawing.Point(100, 112);
            this.numPrecio.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(200, 22);
            this.numPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPrecio.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            // numCosto
            this.numCosto.Location = new System.Drawing.Point(100, 142);
            this.numCosto.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numCosto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCosto.Name = "numCosto";
            this.numCosto.Size = new System.Drawing.Size(200, 22);
            this.numCosto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCosto.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            // numStock
            this.numStock.Location = new System.Drawing.Point(100, 172);
            this.numStock.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numStock.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(200, 22);
            this.numStock.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // numStockMin
            this.numStockMin.Location = new System.Drawing.Point(100, 202);
            this.numStockMin.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numStockMin.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numStockMin.Name = "numStockMin";
            this.numStockMin.Size = new System.Drawing.Size(200, 22);
            this.numStockMin.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // btnAgregar
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(0, 140, 0);
            this.btnAgregar.Location = new System.Drawing.Point(100, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 30);
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // lstProductos
            this.lstProductos.Location = new System.Drawing.Point(12, 275);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(300, 180);
            // btnVerInfo
            this.btnVerInfo.Location = new System.Drawing.Point(12, 463);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(144, 30);
            this.btnVerInfo.Text = "Ver Informacion";
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // btnAlertaStock
            this.btnAlertaStock.ForeColor = System.Drawing.Color.Red;
            this.btnAlertaStock.Location = new System.Drawing.Point(168, 463);
            this.btnAlertaStock.Name = "btnAlertaStock";
            this.btnAlertaStock.Size = new System.Drawing.Size(144, 30);
            this.btnAlertaStock.Text = "Alerta Stock Bajo";
            this.btnAlertaStock.Click += new System.EventHandler(this.btnAlertaStock_Click);
            // btnTodos
            this.btnTodos.Location = new System.Drawing.Point(330, 275);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(540, 30);
            this.btnTodos.Text = "Ver Reporte Completo (Reflection)";
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // txtReporte
            this.txtReporte.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtReporte.Location = new System.Drawing.Point(330, 315);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ReadOnly = true;
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(540, 178);
            // FormInventario
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 510);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblStockMin);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.numCosto);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.numStockMin);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnAlertaStock);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.txtReporte);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario - Peluqueria El Cojo";
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockMin;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numCosto;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numStockMin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAlertaStock;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.ListBox lstProductos;
    }
}