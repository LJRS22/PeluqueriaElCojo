using System;

namespace PeluqueriaElCojo.Atributos
{
    // Valida que un numero este dentro de un rango permitido
    // Ejemplo: [Rango(0, 100)] para porcentajes
    public class RangoAttribute : ValidacionAttribute
    {
        public double Minimo { get; }
        public double Maximo { get; }

        public RangoAttribute(double min, double max)
        {
            Minimo = min;
            Maximo = max;
            MensajeError = string.Format("Debe estar entre {0} y {1}", min, max);
        }

        public override bool EsValido(object valor)
        {
            if (valor == null) return true;
            double num = Convert.ToDouble(valor);
            return num >= Minimo && num <= Maximo;
        }
    }
}