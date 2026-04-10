namespace PeluqueriaElCojo
{
    partial class FormEmpleados
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
            this.lblApodo = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.numSalario = new System.Windows.Forms.NumericUpDown();
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnClonar = new System.Windows.Forms.Button();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 120, 0);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(860, 30);
            this.lblTitulo.Text = "Gestion de Empleados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(12, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.Text = "Nombre:";
            // lblApodo
            this.lblApodo.Location = new System.Drawing.Point(12, 85);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(80, 22);
            this.lblApodo.Text = "Apodo:";
            // lblCedula
            this.lblCedula.Location = new System.Drawing.Point(12, 115);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(80, 22);
            this.lblCedula.Text = "Cedula:";
            // lblTelefono
            this.lblTelefono.Location = new System.Drawing.Point(12, 145);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(80, 22);
            this.lblTelefono.Text = "Telefono:";
            // lblSalario
            this.lblSalario.Location = new System.Drawing.Point(12, 175);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(80, 22);
            this.lblSalario.Text = "Salario:";
            // lblComision
            this.lblComision.Location = new System.Drawing.Point(12, 205);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(80, 22);
            this.lblComision.Text = "Comision %:";
            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(100, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            // txtApodo
            this.txtApodo.Location = new System.Drawing.Point(100, 82);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(200, 22);
            // txtCedula
            this.txtCedula.Location = new System.Drawing.Point(100, 112);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(200, 22);
            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(100, 142);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 22);
            // numSalario
            this.numSalario.Location = new System.Drawing.Point(100, 172);
            this.numSalario.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numSalario.Minimum = new decimal(new int[] { 15000, 0, 0, 0 });
            this.numSalario.Name = "numSalario";
            this.numSalario.Size = new System.Drawing.Size(200, 22);
            this.numSalario.Value = new decimal(new int[] { 20000, 0, 0, 0 });
            this.numSalario.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            // numComision
            this.numComision.Location = new System.Drawing.Point(100, 202);
            this.numComision.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numComision.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numComision.Name = "numComision";
            this.numComision.Size = new System.Drawing.Size(200, 22);
            this.numComision.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // btnAgregar
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(0, 140, 0);
            this.btnAgregar.Location = new System.Drawing.Point(100, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 30);
            this.btnAgregar.Text = "Agregar Empleado";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // lstEmpleados
            this.lstEmpleados.Location = new System.Drawing.Point(12, 275);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(300, 180);
            // btnVerInfo
            this.btnVerInfo.Location = new System.Drawing.Point(12, 463);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(144, 30);
            this.btnVerInfo.Text = "Ver Informacion";
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // btnClonar
            this.btnClonar.Location = new System.Drawing.Point(168, 463);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(144, 30);
            this.btnClonar.Text = "Clonar Empleado";
            this.btnClonar.Click += new System.EventHandler(this.btnClonar_Click);
            // btnRanking
            this.btnRanking.ForeColor = System.Drawing.Color.FromArgb(0, 0, 180);
            this.btnRanking.Location = new System.Drawing.Point(330, 275);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(200, 30);
            this.btnRanking.Text = "Ver Ranking de Barberos";
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // txtReporte
            this.txtReporte.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtReporte.Location = new System.Drawing.Point(330, 315);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ReadOnly = true;
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(540, 178);
            // FormEmpleados
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 510);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApodo);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApodo);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.numSalario);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnClonar);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.txtReporte);
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados - Peluqueria El Cojo";
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApodo;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApodo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.NumericUpDown numSalario;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.ListBox lstEmpleados;
    }
}