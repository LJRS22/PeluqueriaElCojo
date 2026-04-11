using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstEmpleados.Items.Clear();
            foreach (Empleado e in Form1.Empleados)
                lstEmpleados.Items.Add(e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado nuevo = new Empleado();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apodo = txtApodo.Text;
                nuevo.Cedula = txtCedula.Text;
                nuevo.Telefono = txtTelefono.Text;
                nuevo.SalarioBase = (decimal)numSalario.Value;
                nuevo.PorcentajeComision = (decimal)numComision.Value;

                ResultadoValidacion resultado = Validador.Validar(nuevo);
                if (!resultado.EsValido)
                {
                    MessageBox.Show(string.Join("\n", resultado.Errores),
                        "Errores de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Guarda en base de datos y recarga la lista
                int id = Form1.GuardarEmpleado(nuevo);
                ActualizarLista();
                LimpiarCampos();
                MessageBox.Show("Empleado guardado con ID: " + id, "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            // Usa IComparable para ordenar y GeneradorReportes para formatear
            string ranking = GeneradorReportes.GenerarRankingEmpleados(Form1.Empleados);
            txtReporte.Text = ranking;
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            Empleado emp = lstEmpleados.SelectedItem as Empleado;
            if (emp == null)
            {
                MessageBox.Show("Selecciona un empleado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("══════════════════════════════");
            sb.AppendLine("  INFORMACION DEL EMPLEADO");
            sb.AppendLine("══════════════════════════════");
            sb.AppendLine(string.Format("ID:         {0}", emp.Id));
            sb.AppendLine(string.Format("Nombre:     {0}", emp.Nombre));
            sb.AppendLine(string.Format("Apodo:      {0}", emp.Apodo));
            sb.AppendLine(string.Format("Cedula:     {0}", emp.Cedula));
            sb.AppendLine(string.Format("Telefono:   {0}", emp.Telefono));
            sb.AppendLine(string.Format("Rol:        {0}", emp.Rol));
            sb.AppendLine(string.Format("Salario:    RD${0:N0}", emp.SalarioBase));
            sb.AppendLine(string.Format("Comision:   {0}%", emp.PorcentajeComision));
            sb.AppendLine(string.Format("Ventas mes: RD${0:N0}", emp.VentasMes));
            sb.AppendLine(string.Format("Comis. mes: RD${0:N0}", emp.CalcularComision()));
            sb.AppendLine(string.Format("Total mes:  RD${0:N0}", emp.CalcularSalarioTotal()));
            sb.AppendLine("══════════════════════════════");

            txtReporte.Text = sb.ToString();
        }

        private void btnClonar_Click(object sender, EventArgs e)
        {
            Empleado emp = lstEmpleados.SelectedItem as Empleado;
            if (emp == null)
            {
                MessageBox.Show("Selecciona un empleado para clonar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ICloneable en accion: duplicamos configuracion del empleado
            Empleado copia = (Empleado)emp.Clone();
            Form1.Empleados.Add(copia);
            ActualizarLista();

            MessageBox.Show(
                string.Format("Empleado clonado como: {0}\nEdita la cedula antes de guardar.", copia.Nombre),
                "Clonado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApodo.Text = "";
            txtCedula.Text = "";
            txtTelefono.Text = "";
            numSalario.Value = 20000;
            numComision.Value = 10;
        }
    }
}