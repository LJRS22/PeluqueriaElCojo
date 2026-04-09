using System;
using System.Collections.Generic;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Modelos
{
    // Cita implementa ICloneable para poder reagendar facilmente
    // copiando todos los datos de una cita cancelada a una nueva fecha
    public class Cita : ICloneable
    {
        private static int _contadorId = 0;

        // ── PROPIEDADES ───────────────────────────────────────────────────────

        public int Id { get; private set; }

        // La fecha en que esta programada la cita
        [Requerido]
        public DateTime Fecha { get; set; }

        // La hora exacta dentro de ese dia
        [Requerido]
        public TimeSpan Hora { get; set; }

        // El cliente que viene a la cita
        [Requerido]
        public Cliente Cliente { get; set; }

        // El barbero que va a atender
        [Requerido]
        public Empleado Barbero { get; set; }

        // Estado actual de la cita en su ciclo de vida
        public EstadoCita Estado { get; set; }

        // Lista de servicios que se van a realizar en esta cita
        public List<Servicio> Servicios { get; set; }

        // Notas adicionales, por ejemplo "cliente alérgico a cierto producto"
        [Longitud(0, 200)]
        public string Notas { get; set; }

        // Fecha en que se creo la cita en el sistema
        public DateTime FechaCreacion { get; private set; }

        // ── CONSTRUCTOR ───────────────────────────────────────────────────────
        public Cita()
        {
            Id = ++_contadorId;
            FechaCreacion = DateTime.Now;
            Estado = EstadoCita.Pendiente;
            Servicios = new List<Servicio>();
            // Por defecto se agenda para hoy a las 9am
            Fecha = DateTime.Today;
            Hora = new TimeSpan(9, 0, 0);
        }

        // ── ICLONEABLE: duplicar una cita para reagendarla ────────────────────
        // Cuando un cliente cancela y quiere otra fecha, clonamos la cita
        // y solo cambiamos la fecha y hora, todo lo demas queda igual
        public object Clone()
        {
            Cita copia = new Cita();
            copia.Cliente = this.Cliente;
            copia.Barbero = this.Barbero;
            copia.Estado = EstadoCita.Pendiente;
            copia.Notas = this.Notas;

            // Copiamos todos los servicios que tenia la cita original
            foreach (Servicio s in this.Servicios)
            {
                copia.Servicios.Add(s);
            }

            // La fecha se deja en blanco para que el usuario la configure
            return copia;
        }

        // ── PROPIEDADES CALCULADAS ────────────────────────────────────────────

        // Combina fecha y hora en un solo DateTime para comparaciones
        public DateTime FechaHoraCompleta
        {
            get { return Fecha.Date.Add(Hora); }
        }

        // Suma los minutos de todos los servicios para saber cuanto dura la cita
        public int DuracionTotalMinutos
        {
            get
            {
                int total = 0;
                foreach (Servicio s in Servicios)
                {
                    total += s.DuracionMinutos;
                }
                return total;
            }
        }

        // Suma los precios de todos los servicios sin ITBIS ni descuento
        public decimal TotalEstimado
        {
            get
            {
                decimal total = 0;
                foreach (Servicio s in Servicios)
                {
                    total += s.CalcularPrecio();
                }
                return total;
            }
        }

        // ── METODOS DE CAMBIO DE ESTADO ───────────────────────────────────────

        // Solo se puede confirmar si esta pendiente
        public void Confirmar()
        {
            if (Estado == EstadoCita.Pendiente)
                Estado = EstadoCita.Confirmada;
        }

        // Solo se puede iniciar si esta confirmada
        public void Iniciar()
        {
            if (Estado == EstadoCita.Confirmada)
                Estado = EstadoCita.EnProceso;
        }

        // Solo se puede completar si esta en proceso
        public void Completar()
        {
            if (Estado == EstadoCita.EnProceso)
                Estado = EstadoCita.Completada;
        }

        // Se puede cancelar en cualquier estado menos completada
        public void Cancelar()
        {
            if (Estado != EstadoCita.Completada)
                Estado = EstadoCita.Cancelada;
        }

        public override string ToString()
        {
            string clienteNombre = Cliente != null ? Cliente.Nombre : "?";
            string barberoNombre = Barbero != null ?
                (string.IsNullOrEmpty(Barbero.Apodo) ? Barbero.Nombre : Barbero.Apodo) : "?";

            return string.Format("{0:dd/MM} {1:hh\\:mm} - {2} con {3} [{4}]",
                Fecha, Hora, clienteNombre, barberoNombre, Estado);
        }
    }
}
