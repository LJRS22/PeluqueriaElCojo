using System;
using System.Windows.Forms;

namespace PeluqueriaElCojo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostramos el login antes del menu principal
            FormLogin login = new FormLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Si el login fue exitoso abrimos el menu principal
                Application.Run(new Form1());
            }
        }
    }
}