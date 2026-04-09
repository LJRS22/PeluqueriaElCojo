namespace PeluqueriaElCojo
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.chkCorteNormal = new System.Windows.Forms.CheckBox();
            this.chkDegradado = new System.Windows.Forms.CheckBox();
            this.chkAfeitado = new System.Windows.Forms.CheckBox();
            this.chkToalla = new System.Windows.Forms.CheckBox();
            this.chkCejas = new System.Windows.Forms.CheckBox();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            this.SuspendLayout();
            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(30, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(30, 175);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 22);
            this.txtTelefono.TabIndex = 1;
            // txtRecibo
            this.txtRecibo.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtRecibo.Location = new System.Drawing.Point(525, 12);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecibo.Size = new System.Drawing.Size(384, 432);
            this.txtRecibo.TabIndex = 11;
            this.txtRecibo.TextChanged += new System.EventHandler(this.txtRecibo_TextChanged);
            // btnAgregarCliente
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.btnAgregarCliente.Location = new System.Drawing.Point(245, 116);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(120, 31);
            this.btnAgregarCliente.TabIndex = 2;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // btnCobrar
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCobrar.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.btnCobrar.Location = new System.Drawing.Point(280, 349);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(200, 35);
            this.btnCobrar.TabIndex = 10;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // lstClientes
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(12, 217);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(240, 148);
            this.lstClientes.TabIndex = 3;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // chkCorteNormal
            this.chkCorteNormal.Location = new System.Drawing.Point(280, 217);
            this.chkCorteNormal.Name = "chkCorteNormal";
            this.chkCorteNormal.Size = new System.Drawing.Size(200, 24);
            this.chkCorteNormal.TabIndex = 4;
            this.chkCorteNormal.Text = "Corte Normal (RD$500)";
            // chkDegradado
            this.chkDegradado.Location = new System.Drawing.Point(280, 247);
            this.chkDegradado.Name = "chkDegradado";
            this.chkDegradado.Size = new System.Drawing.Size(104, 24);
            this.chkDegradado.TabIndex = 5;
            this.chkDegradado.Text = "Degradado";
            // chkAfeitado
            this.chkAfeitado.Location = new System.Drawing.Point(280, 277);
            this.chkAfeitado.Name = "chkAfeitado";
            this.chkAfeitado.Size = new System.Drawing.Size(200, 24);
            this.chkAfeitado.TabIndex = 7;
            this.chkAfeitado.Text = "Afeitado (RD$150)";
            this.chkAfeitado.CheckedChanged += new System.EventHandler(this.chkAfeitado_CheckedChanged);
            // chkToalla
            this.chkToalla.Location = new System.Drawing.Point(390, 277);
            this.chkToalla.Name = "chkToalla";
            this.chkToalla.Size = new System.Drawing.Size(130, 24);
            this.chkToalla.TabIndex = 8;
            this.chkToalla.Text = "+ Toalla (+RD$50)";
            // chkCejas
            this.chkCejas.Location = new System.Drawing.Point(280, 307);
            this.chkCejas.Name = "chkCejas";
            this.chkCejas.Size = new System.Drawing.Size(150, 24);
            this.chkCejas.TabIndex = 9;
            this.chkCejas.Text = "Cejas (RD$75)";
            this.chkCejas.CheckedChanged += new System.EventHandler(this.chkCejas_CheckedChanged);
            // numNivel
            this.numNivel.Location = new System.Drawing.Point(390, 247);
            this.numNivel.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numNivel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(120, 22);
            this.numNivel.TabIndex = 6;
            this.numNivel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // lblTotal
            this.lblTotal.Location = new System.Drawing.Point(12, 382);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(240, 25);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "TOTAL: RD$0";
            // label1
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // label2
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefono:";
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.chkCorteNormal);
            this.Controls.Add(this.chkDegradado);
            this.Controls.Add(this.numNivel);
            this.Controls.Add(this.chkAfeitado);
            this.Controls.Add(this.chkToalla);
            this.Controls.Add(this.chkCejas);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.lblTotal);
            this.Name = "Form1";
            this.Text = "Peluquería El Cojo";
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.CheckBox chkCorteNormal;
        private System.Windows.Forms.CheckBox chkDegradado;
        private System.Windows.Forms.CheckBox chkAfeitado;
        private System.Windows.Forms.CheckBox chkToalla;
        private System.Windows.Forms.CheckBox chkCejas;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}