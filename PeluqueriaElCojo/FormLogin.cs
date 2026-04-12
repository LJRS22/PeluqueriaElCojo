using System;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Datos;

namespace PeluqueriaElCojo
{
    public partial class FormLogin : Form
    {
        // Usuario autenticado accesible desde cualquier formulario
        public static Usuario UsuarioActual = null;

        private UsuarioRepository _usuarioRepo = new UsuarioRepository();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contrasena.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica credenciales contra la base de datos
            Usuario u = _usuarioRepo.Autenticar(usuario, contrasena);

            if (u == null)
            {
                MessageBox.Show("Usuario o contrasena incorrectos.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Text = "";
                txtContrasena.Focus();
                return;
            }

            // Login exitoso guardamos el usuario actual
            UsuarioActual = u;
            MessageBox.Show(
                string.Format("Bienvenido, {0}!\nRol: {1}", u.NombreUsuario, u.Rol),
                "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Permite presionar Enter en contrasena para iniciar sesion
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnEntrar_Click(sender, e);
        }
    }
}