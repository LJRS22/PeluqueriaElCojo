namespace PeluqueriaElCojo.Modelos
{
    // Roles del sistema para controlar acceso a los modulos
    public enum RolSistema
    {
        Administrador = 0,
        Recepcionista = 1,
        Barbero = 2
    }

    // Representa un usuario del sistema con su rol de acceso
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public RolSistema Rol { get; set; }
        public bool Activo { get; set; }
        //Agrego Login, privilegios por rol, Backup del sistema y actualizo base de datos con tabla Usuarios
        public override string ToString()
        {
            return string.Format("{0} ({1})", NombreUsuario, Rol);
        }
    }
}