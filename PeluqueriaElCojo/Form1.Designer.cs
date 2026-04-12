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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 120, 0);
            this.lblTitulo.Location = new System.Drawing.Point(50, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Peluqueria El Cojo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblSubtitulo
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(50, 90);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(600, 30);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Villa Mella, Santo Domingo";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnClientes
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClientes.Location = new System.Drawing.Point(150, 160);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(300, 60);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // btnEmpleados
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEmpleados.Location = new System.Drawing.Point(150, 240);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(300, 60);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // btnInventario
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnInventario.Location = new System.Drawing.Point(150, 320);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(300, 60);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // btnFacturacion
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFacturacion.ForeColor = System.Drawing.Color.FromArgb(0, 140, 0);
            this.btnFacturacion.Location = new System.Drawing.Point(150, 400);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(300, 60);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // btnBackup
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(0, 0, 180);
            this.btnBackup.Location = new System.Drawing.Point(150, 480);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(300, 60);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Backup del Sistema";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // lblVersion
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(50, 560);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(600, 20);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "ISW-123 Programacion Media - Universidad Central del Este";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblVersion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peluqueria El Cojo - Menu Principal";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblVersion;
    }
}