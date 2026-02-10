using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Modelos
{
    public class Servicio : IFacturable
    {
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
        public int DuracionMinutos { get; set; }

        public Servicio(string nombre, decimal precio, int duracion)
        {
            Nombre = nombre;
            PrecioBase = precio;
            DuracionMinutos = duracion;
        }

        public virtual decimal CalcularPrecio()
        {
            return PrecioBase;
        }

        public virtual string GenerarLineaRecibo()
        {
            return string.Format("{0,-20} RD${1:N0}", Nombre, CalcularPrecio());
        }
    }
}
