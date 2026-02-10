using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Modelos
{
    public class ComboCompleto : Servicio
    {
        public ComboCompleto() : base("Combo Completo", 500, 60)
        {
        }

        public override decimal CalcularPrecio()
        {
            return 500;
        }

        public override string GenerarLineaRecibo()
        {
            return string.Format("{0,-20} RD${1:N0}", "* COMBO *", 500);
        }
    }
}
