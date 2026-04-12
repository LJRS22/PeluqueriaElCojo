namespace PeluqueriaElCojo
{
    partial class FormBackup
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
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 120, 0);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 30);
            this.lblTitulo.Text = "Backup del Sistema";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblInfo
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(12, 45);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(760, 20);
            this.lblInfo.Text = "Genera un archivo SQL con todos los datos del sistema y lo guarda en el Escritorio.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnBackup
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(0, 140, 0);
            this.btnBackup.Location = new System.Drawing.Point(200, 75);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 40);
            this.btnBackup.Text = "Generar Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // btnCerrar
            this.btnCerrar.Location = new System.Drawing.Point(420, 75);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 40);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // txtResultado
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtResultado.Location = new System.Drawing.Point(12, 125);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(760, 340);
            // FormBackup
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 480);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtResultado);
            this.Name = "FormBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup - Peluqueria El Cojo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtResultado;
    }
}