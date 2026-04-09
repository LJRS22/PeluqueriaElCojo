namespace PeluqueriaElCojo.Modelos
{
    // Estados por los que pasa una cita desde que se agenda hasta completarse
    public enum EstadoCita
    {
        Pendiente,
        Confirmada,
        EnProceso,
        Completada,
        Cancelada,
        NoAsistio
    }
}