using Patrones_de_Diseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar un mensaje de bienvenida en la consola
            Console.WriteLine("Bienvenido al programa de ejemplo de Singleton y Patrones de Diseño.");

            // Obtener la instancia de AppConfig utilizando el patrón Singleton
            var config = AppConfig.GetInstance();

            // Acceder y modificar las propiedades de configuración
            Console.WriteLine("Nombre de la aplicación: " + config.AppName);
            Console.WriteLine("Versión: " + config.Version);
            Console.WriteLine("Tema actual: " + config.Theme);

            // Cambiar el tema
            config.Theme = "Oscuro";
            Console.WriteLine("Tema actualizado a: " + config.Theme);

            // Punto de pausa para evitar que la consola se cierre inmediatamente
            Console.ReadLine();
        }
    }
}

