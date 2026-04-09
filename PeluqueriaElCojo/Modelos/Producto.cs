using System;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Modelos
{
    // Producto implementa IEquatable para que el sistema detecte
    // automaticamente si ya existe un producto con el mismo codigo
    public class Producto : IEquatable<Producto>
    {
        private static int _contadorId = 0;

        // ── PROPIEDADES CON ATRIBUTOS DE VALIDACION ──────────────────────────

        public int Id { get; private set; }

        // El codigo identifica unicamente al producto (como un codigo de barras)
        [Requerido]
        [Longitud(4, 20)]
        public string Codigo { get; set; }

        // El nombre del producto es obligatorio
        [Requerido]
        [Longitud(3, 50)]
        public string Nombre { get; set; }

        // Categoria para organizar el inventario
        public CategoriaProducto Categoria { get; set; }

        // El precio de venta al cliente
        [Rango(1, 50000)]
        public decimal Precio { get; set; }

        // El costo que le cuesta a la peluqueria comprar el producto
        [Rango(1, 50000)]
        public decimal Costo { get; set; }

        // Cuantas unidades hay actualmente en el inventario
        [Rango(0, 9999)]
        public int Stock { get; set; }

        // Cuando el stock baje de este numero hay que reponer
        [Rango(0, 100)]
        public int StockMinimo { get; set; }

        public bool Activo { get; set; }

        // ── CONSTRUCTOR ───────────────────────────────────────────────────────
        public Producto()
        {
            Id = ++_contadorId;
            Activo = true;
            StockMinimo = 5;
            Categoria = CategoriaProducto.Otros;
        }

        // ── IEQUATABLE: comparar productos por codigo ─────────────────────────
        // Dos productos son el mismo si tienen el mismo codigo
        // sin importar mayusculas o minusculas
        public bool Equals(Producto otro)
        {
            if (otro == null) return false;
            return string.Equals(this.Codigo, otro.Codigo,
                StringComparison.OrdinalIgnoreCase);
        }

        // Necesario para que funcione correctamente en Dictionary y HashSet
        // Si dos objetos son iguales, deben tener el mismo HashCode
        public override bool Equals(object obj)
        {
            return Equals(obj as Producto);
        }

        public override int GetHashCode()
        {
            if (Codigo == null) return 0;
            return Codigo.ToUpperInvariant().GetHashCode();
        }

        // ── PROPIEDADES CALCULADAS ────────────────────────────────────────────

        // Cuanto gana la peluqueria por cada unidad vendida
        public decimal Ganancia
        {
            get { return Precio - Costo; }
        }

        // Porcentaje de ganancia sobre el costo
        public decimal MargenPorcentaje
        {
            get
            {
                if (Costo == 0) return 0;
                return (Ganancia / Costo) * 100;
            }
        }

        // Indica si hay que ir a comprar mas de este producto
        public bool RequiereReposicion
        {
            get { return Stock <= StockMinimo; }
        }

        // Valor total del stock actual en costo
        public decimal ValorInventario
        {
            get { return Stock * Costo; }
        }

        // ── METODOS DE NEGOCIO ────────────────────────────────────────────────

        // Agrega unidades al inventario cuando llega mercancia
        public void AgregarStock(int cantidad)
        {
            if (cantidad > 0)
                Stock += cantidad;
        }

        // Descuenta unidades cuando se vende, retorna false si no hay suficiente
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