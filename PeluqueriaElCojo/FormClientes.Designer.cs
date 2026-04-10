namespace PeluqueriaElCojo
{
    partial class FormClientes
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 120, 0);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 30);
            this.lblTitulo.Text = "Gestion de Clientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(12, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.Text = "Nombre:";
            // lblTelefono
            this.lblTelefono.Location = new System.Drawing.Point(12, 85);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(80, 22);
            this.lblTelefono.Text = "Telefono:";
            // lblBuscar
            this.lblBuscar.Location = new System.Drawing.Point(12, 145);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(80, 22);
            this.lblBuscar.Text = "Buscar:";
            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(100, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(100, 82);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 22);
            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(100, 142);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 22);
            // txtInfo
            this.txtInfo.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtInfo.Location = new System.Drawing.Point(530, 50);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(240, 380);
            // btnAgregar
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(0, 140, 0);
            this.btnAgregar.Location = new System.Drawing.Point(100, 112);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 28);
            this.btnAgregar.Text = "Agregar Cliente";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(100, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 28);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(205, 170);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 28);
            this.btnLimpiar.Text = "Ver Todos";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // lstClientes
            this.lstClientes.Location = new System.Drawing.Point(12, 210);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(500, 220);
            // btnVerInfo
            this.btnVerInfo.Location = new System.Drawing.Point(12, 440);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(500, 30);
            this.btnVerInfo.Text = "Ver Informacion del Cliente Seleccionado";
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // FormClientes
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 490);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.txtInfo);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes - Peluqueria El Cojo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstClientes;
    }
}