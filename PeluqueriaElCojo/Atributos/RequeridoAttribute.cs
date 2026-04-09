using System;

namespace PeluqueriaElCojo.Atributos
{
    // Marca una propiedad como obligatoria
    // Si el valor esta vacio o nulo, la validacion falla
    public class RequeridoAttribute : ValidacionAttribute
    {
        public RequeridoAttribute()
        {
            MensajeError = "Este campo es requerido";
        }

        public override bool EsValido(object valor)
        {
            if (valor == null) return false;
            if (valor is string s) return !string.IsNullOrWhiteSpace(s);
            return true;
        }
    }
}