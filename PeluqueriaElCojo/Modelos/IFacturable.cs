using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Modelos
{
    public interface IFacturable
    {
        decimal CalcularPrecio();
        string GenerarLineaRecibo();
    }
}
