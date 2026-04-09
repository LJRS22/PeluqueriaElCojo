using System;
using System.Collections.Generic;
using System.Reflection;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Utilidades
{
    // Clase que guarda el resultado de validar un objeto
    // contiene si paso la validacion y la lista de errores encontrados
    public class ResultadoValidacion
    {
        public bool EsValido { get; set; }
        public List<string> Errores { get; set; }

        public ResultadoValidacion()
        {
            EsValido = true;
            Errores = new List<string>();
        }
    }

    // Validador generico que funciona con cualquier clase
    // usa Reflection para leer los atributos de cada propiedad
    // y verificar si los valores cumplen las reglas definidas
    public static class Validador
    {
        // Metodo principal: recibe cualquier objeto y devuelve si es valido
        // La magia esta en que no necesita saber que tipo de objeto es
        // Reflection se encarga de inspeccionar las propiedades en tiempo de ejecucion
        public static ResultadoValidacion Validar<T>(T objeto)
        {
            ResultadoValidacion resultado = new ResultadoValidacion();

            // Si el objeto es nulo no hay nada que validar
            if (objeto == null)
            {
                resultado.EsValido = false;
                resultado.Errores.Add("El objeto es nulo");
                return resultado;
            }

            // REFLECTION paso 1: obtenemos el tipo del objeto en tiempo de ejecucion
            // Es como preguntarle al objeto "que clase eres tu?"
            Type tipo = objeto.GetType();

            // REFLECTION paso 2: obtenemos todas las propiedades publicas del objeto
            // Es como ver todos los campos de un formulario
            PropertyInfo[] propiedades = tipo.GetProperties();

            // Recorremos cada propiedad para revisar si tiene atributos de validacion
            foreach (PropertyInfo prop in propiedades)
            {
                // REFLECTION paso 3: obtenemos el valor actual de esta propiedad
                // Es como leer lo que el usuario escribio en ese campo
                object valor = prop.GetValue(objeto);

                // Buscamos el nombre amigable para mostrar en los errores
                string nombreProp = ObtenerNombreAmigable(prop);

                // REFLECTION paso 4: buscamos todos los atributos de validacion
                // que tenga esta propiedad, por ejemplo [Requerido] o [Rango(0,100)]
                object[] atributos = prop.GetCustomAttributes(
                    typeof(ValidacionAttribute), true);

                // Ejecutamos cada validacion que encontramos
                foreach (object attr in atributos)
                {
                    ValidacionAttribute validacion = attr as ValidacionAttribute;

                    // Si el valor no pasa la validacion, guardamos el error
                    if (validacion != null && !validacion.EsValido(valor))
                    {
                        resultado.EsValido = false;
                        resultado.Errores.Add(
                            string.Format("{0}: {1}", nombreProp, validacion.MensajeError));
                    }
                }
            }

            return resultado;
        }

        // Busca si la propiedad tiene un nombre mas amigable definido
        // Si no tiene, usa el nombre tecnico de la propiedad
        private static string ObtenerNombreAmigable(PropertyInfo prop)
        {
            return prop.Name;
        }
    }
}