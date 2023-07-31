using System;

namespace Patrones_de_Diseño
{
    public class AppConfig
    {
        // Variables y métodos del Singleton, como se mostró en ejemplos anteriores
        // ...

        // Propiedades públicas para configuración
        public string AppName { get; set; }
        public string Version { get; set; }
        public string Theme { get; set; }

        private AppConfig()
        {
            // Inicializamos algunas configuraciones predeterminadas
            AppName = "Mi Aplicación";
            Version = "1.0";
            Theme = "Predeterminado";
        }

        private static AppConfig instance;

        public static AppConfig GetInstance()
        {
            if (instance == null)
            {
                instance = new AppConfig();
            }
            return instance;
        }
    }
}
