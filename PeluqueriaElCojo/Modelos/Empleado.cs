using System;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Modelos
{
    // Empleado implementa IComparable para poder ordenar la lista por ventas
    // e ICloneable para duplicar la configuracion de un empleado como plantilla
    public class Empleado : IComparable<Empleado>, ICloneable
    {
        private static int _contadorId = 0;

        // ── PROPIEDADES CON ATRIBUTOS DE VALIDACION ──────────────────────────

        // El Id se oculta en formularios porque lo asigna el sistema
        public int Id { get; private set; }

        // El nombre es obligatorio y debe tener entre 3 y 50 caracteres
        [Requerido]
        [Longitud(3, 50)]
        public string Nombre { get; set; }

        // El apodo es opcional, aparece en recibos y rankings
        public string Apodo { get; set; }

        // La cedula es obligatoria y unica por empleado
        [Requerido]
        [Longitud(11, 13)]
        public string Cedula { get; set; }

        // El telefono debe tener formato dominicano valido
        [TelefonoDominicano]
        public string Telefono { get; set; }

        // El rol define si es barbero, recepcionista o administrador
        public RolEmpleado Rol { get; set; }

        // El salario base debe estar entre RD$15,000 y RD$100,000
        [Rango(15000, 100000)]
        public decimal SalarioBase { get; set; }

        // La comision es un porcentaje entre 0% y 50%
        [Rango(0, 50)]
        public decimal PorcentajeComision { get; set; }

        // Las ventas del mes se usan para calcular comision y el ranking
        public decimal VentasMes { get; set; }

        public DateTime FechaIngreso { get; private set; }
        public bool Activo { get; set; }

        // ── CONSTRUCTOR ───────────────────────────────────────────────────────
        public Empleado()
        {
            Id = ++_contadorId;
            FechaIngreso = DateTime.Now;
            Activo = true;
            Rol = RolEmpleado.Barbero;
            PorcentajeComision = 10;
            SalarioBase = 20000;
        }

        // ── ICOMPARABLE: ordenar por ventas de mayor a menor ─────────────────
        // Cuando llamemos lista.Sort(), automaticamente usa este metodo
        // Retorna positivo si 'otro' tiene mas ventas (para orden descendente)
        public int CompareTo(Empleado otro)
        {
            if (otro == null) return 1;
            return otro.VentasMes.CompareTo(this.VentasMes);
        }

        // ── ICLONEABLE: crear una copia del empleado como plantilla ───────────
        // Util para contratar un nuevo barbero con la misma configuracion
        // La cedula se deja vacia porque es unica para cada persona
        public object Clone()
        {
            Empleado copia = new Empleado();
            copia.Nombre = this.Nombre + " (Copia)";
            copia.Apodo = this.Apodo;
            copia.Cedula = "";
            copia.Telefono = this.Telefono;
            copia.Rol = this.Rol;
            copia.SalarioBase = this.SalarioBase;
            copia.PorcentajeComision = this.PorcentajeComision;
            return copia;
        }

        // ── METODOS DE NEGOCIO ────────────────────────────────────────────────

        // Calcula cuanto gano el empleado en comisiones este mes
        public decimal CalcularComision()
        {
            return VentasMes * (PorcentajeComision / 100m);
        }

        // Salario total = salario base + lo que gano en comisiones
        public decimal CalcularSalarioTotal()
        {
            return SalarioBase + CalcularComision();
        }

        // Muestra el apodo si tiene, sino el nombre completo
        public override string ToString()
        {
            string display = string.IsNullOrEmpty(Apodo) ? Nombre : Apodo;
            return string.Format("[{0}] {1} ({2})", Id, display, Rol);
        }
    }
}