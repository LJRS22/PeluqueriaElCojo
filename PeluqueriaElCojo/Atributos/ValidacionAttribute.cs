using System;

namespace PeluqueriaElCojo.Atributos
{
    // Clase base abstracta para todos los atributos de validacion
    // Cualquier atributo que valide datos debe heredar de esta clase
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class ValidacionAttribute : Attribute
    {
        // Mensaje que se muestra cuando la validacion falla
        public string MensajeError { get; set; }

        // Cada atributo hijo decide como validar su propio valor
        public abstract bool EsValido(object valor);
    }
}
