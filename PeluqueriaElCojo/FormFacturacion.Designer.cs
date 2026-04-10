namespace PeluqueriaElCojo
{
    partial class FormFacturacion
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblServicios = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.chkCorteNormal = new System.Windows.Forms.CheckBox();
            this.chkDegradado = new System.Windows.Forms.CheckBox();
            this.chkAfeitado = new System.Windows.Forms.CheckBox();
            this.chkToalla = new System.Windows.Forms.CheckBox();
            this.chkCejas = new System.Windows.Forms.CheckBox();
            this.chkCombo = new System.Windows.Forms.CheckBox();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 120, 0);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(860, 30);
            this.lblTitulo.Text = "Facturacion";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblCliente
            this.lblCliente.Location = new System.Drawing.Point(12, 55);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 22);
            this.lblCliente.Text = "Cliente:";
            // lblEmpleado
            this.lblEmpleado.Location = new System.Drawing.Point(12, 85);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(80, 22);
            this.lblEmpleado.Text = "Barbero:";
            // lblServicios
            this.lblServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblServicios.Location = new System.Drawing.Point(12, 125);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(300, 22);
            this.lblServicios.Text = "Servicios:";
            // cmbCliente
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Location = new System.Drawing.Point(100, 52);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(280, 24);
            // cmbEmpleado
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.Location = new System.Drawing.Point(100, 82);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(280, 24);
            // chkCorteNormal
            this.chkCorteNormal.Location = new System.Drawing.Point(12, 155);
            this.chkCorteNormal.Name = "chkCorteNormal";
            this.chkCorteNormal.Size = new System.Drawing.Size(200, 24);
            this.chkCorteNormal.Text = "Corte Normal (RD$500)";
            // chkDegradado
            this.chkDegradado.Location = new System.Drawing.Point(12, 185);
            this.chkDegradado.Name = "chkDegradado";
            this.chkDegradado.Size = new System.Drawing.Size(130, 24);
            this.chkDegradado.Text = "Degradado Nivel:";
            // lblNivel
            this.lblNivel.Location = new System.Drawing.Point(148, 188);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(40, 22);
            this.lblNivel.Text = "Nivel:";
            // numNivel
            this.numNivel.Location = new System.Drawing.Point(190, 185);
            this.numNivel.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numNivel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(60, 22);
            this.numNivel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // chkAfeitado
            this.chkAfeitado.Location = new System.Drawing.Point(12, 215);
            this.chkAfeitado.Name = "chkAfeitado";
            this.chkAfeitado.Size = new System.Drawing.Size(160, 24);
            this.chkAfeitado.Text = "Afeitado (RD$150)";
            // chkToalla
            this.chkToalla.Location = new System.Drawing.Point(180, 215);
            this.chkToalla.Name = "chkToalla";
            this.chkToalla.Size = new System.Drawing.Size(150, 24);
            this.chkToalla.Text = "+ Toalla (+RD$50)";
            // chkCejas
            this.chkCejas.Location = new System.Drawing.Point(12, 245);
            this.chkCejas.Name = "chkCejas";
            this.chkCejas.Size = new System.Drawing.Size(200, 24);
            this.chkCejas.Text = "Corte de Cejas (RD$75)";
            // chkCombo
            this.chkCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.chkCombo.ForeColor = System.Drawing.Color.FromArgb(0, 100, 0);
            this.chkCombo.Location = new System.Drawing.Point(12, 275);
            this.chkCombo.Name = "chkCombo";
            this.chkCombo.Size = new System.Drawing.Size(280, 24);
            this.chkCombo.Text = "COMBO COMPLETO (RD$500)";
            // btnCobrar
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.FromArgb(0, 140, 0);
            this.btnCobrar.Location = new System.Drawing.Point(12, 315);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(180, 40);
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(200, 315);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(180, 40);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // txtRecibo
            this.txtRecibo.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtRecibo.Location = new System.Drawing.Point(420, 50);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.ReadOnly = true;
            this.txtRecibo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecibo.Size = new System.Drawing.Size(440, 350);
            // lblTotal
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(0, 120, 0);
            this.lblTotal.Location = new System.Drawing.Point(12, 370);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(380, 30);
            this.lblTotal.Text = "TOTAL: RD$0.00";
            // FormFacturacion
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 420);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.chkCorteNormal);
            this.Controls.Add(this.chkDegradado);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.numNivel);
            this.Controls.Add(this.chkAfeitado);
            this.Controls.Add(this.chkToalla);
            this.Controls.Add(this.chkCejas);
            this.Controls.Add(this.chkCombo);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.lblTotal);
            this.Name = "FormFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion - Peluqueria El Cojo";
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.CheckBox chkCorteNormal;
        private System.Windows.Forms.CheckBox chkDegradado;
        private System.Windows.Forms.CheckBox chkAfeitado;
        private System.Windows.Forms.CheckBox chkToalla;
        private System.Windows.Forms.CheckBox chkCejas;
        private System.Windows.Forms.CheckBox chkCombo;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label lblTotal;
    }
}