using System;

namespace PeluqueriaElCojo.Atributos
{
    // Valida que el telefono tenga formato dominicano valido
    // Acepta prefijos 809, 829 y 849 con exactamente 10 digitos
    public class TelefonoDominicanoAttribute : ValidacionAttribute
    {
        public TelefonoDominicanoAttribute()
        {
            MensajeError = "Telefono invalido. Use formato: 809-555-1234";
        }

        public override bool EsValido(object valor)
        {
            if (valor == null) return false;

            // Limpiamos guiones y espacios antes de validar
            string tel = valor.ToString().Replace("-", "").Replace(" ", "");

            if (tel.Length != 10) return false;

            // Solo se aceptan los tres prefijos validos en RD
            string prefijo = tel.Substring(0, 3);
            return prefijo == "809" || prefijo == "829" || prefijo == "849";
        }
    }
}
