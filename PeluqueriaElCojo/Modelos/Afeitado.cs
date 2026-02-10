using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Modelos
{
    public class Afeitado : Servicio
    {
        public bool ConToalla { get; set; }

        public Afeitado(bool conToalla) : base("Afeitado", 150, 15)
        {
            ConToalla = conToalla;
        }

        public Afeitado() : this(false)
        {
        }

        public override decimal CalcularPrecio()
        {
            if (ConToalla)
                return PrecioBase + 50;

            return PrecioBase;
        }

        public override string GenerarLineaRecibo()
        {
            string txt = ConToalla ? "Afeitado + Toalla" : "Afeitado";

            return string.Format("{0,-20} RD${1:N0}", txt, CalcularPrecio());
        }
    }
}


