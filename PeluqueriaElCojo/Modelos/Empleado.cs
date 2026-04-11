using System;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Modelos
{
    public class Empleado : IComparable<Empleado>, ICloneable
    {
        private static int _contadorId = 0;

        // Id ahora tiene set publico para que Reflection pueda asignarlo
        public int Id { get; set; }

        [Requerido]
        [Longitud(3, 50)]
        public string Nombre { get; set; }

        public string Apodo { get; set; }

        [Requerido]
        [Longitud(11, 13)]
        public string Cedula { get; set; }

        [TelefonoDominicano]
        public string Telefono { get; set; }

        public RolEmpleado Rol { get; set; }

        [Rango(15000, 100000)]
        public decimal SalarioBase { get; set; }

        [Rango(0, 50)]
        public decimal PorcentajeComision { get; set; }

        public decimal VentasMes { get; set; }

        public DateTime FechaIngreso { get; private set; }
        public bool Activo { get; set; }

        public Empleado()
        {
            Id = ++_contadorId;
            FechaIngreso = DateTime.Now;
            Activo = true;
            Rol = RolEmpleado.Barbero;
            PorcentajeComision = 10;
            SalarioBase = 20000;
        }

        // IComparable: ordena por ventas de mayor a menor
        public int CompareTo(Empleado otro)
        {
            if (otro == null) return 1;
            return otro.VentasMes.CompareTo(this.VentasMes);
        }

        // ICloneable: duplica configuracion como plantilla
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

        public decimal CalcularComision()
        {
            return VentasMes * (PorcentajeComision / 100m);
        }

        public decimal CalcularSalarioTotal()
        {
            return SalarioBase + CalcularComision();
        }

        public override string ToString()
        {
            string display = string.IsNullOrEmpty(Apodo) ? Nombre : Apodo;
            return string.Format("[{0}] {1} ({2})", Id, display, Rol);
        }
    }
}