using System;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Modelos
{
    public class Producto : IEquatable<Producto>
    {
        private static int _contadorId = 0;

        // Id ahora tiene set publico para que Reflection pueda asignarlo
        public int Id { get; set; }

        [Requerido]
        [Longitud(4, 20)]
        public string Codigo { get; set; }

        [Requerido]
        [Longitud(3, 50)]
        public string Nombre { get; set; }

        public CategoriaProducto Categoria { get; set; }

        [Rango(1, 50000)]
        public decimal Precio { get; set; }

        [Rango(1, 50000)]
        public decimal Costo { get; set; }

        [Rango(0, 9999)]
        public int Stock { get; set; }

        [Rango(0, 100)]
        public int StockMinimo { get; set; }

        public bool Activo { get; set; }

        public Producto()
        {
            Id = ++_contadorId;
            Activo = true;
            StockMinimo = 5;
            Categoria = CategoriaProducto.Otros;
        }

        // IEquatable: compara productos por codigo ignorando mayusculas
        public bool Equals(Producto otro)
        {
            if (otro == null) return false;
            return string.Equals(this.Codigo, otro.Codigo,
                StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Producto);
        }

        public override int GetHashCode()
        {
            if (Codigo == null) return 0;
            return Codigo.ToUpperInvariant().GetHashCode();
        }

        public decimal Ganancia
        {
            get { return Precio - Costo; }
        }

        public decimal MargenPorcentaje
        {
            get
            {
                if (Costo == 0) return 0;
                return (Ganancia / Costo) * 100;
            }
        }

        public bool RequiereReposicion
        {
            get { return Stock <= StockMinimo; }
        }

        public decimal ValorInventario
        {
            get { return Stock * Costo; }
        }

        public void AgregarStock(int cantidad)
        {
            if (cantidad > 0)
                Stock += cantidad;
        }

        public bool DescontarStock(int cantidad)
        {
            if (cantidad > 0 && Stock >= cantidad)
            {
                Stock -= cantidad;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1} - RD${2:N0} (Stock: {3})",
                Codigo, Nombre, Precio, Stock);
        }
    }
}