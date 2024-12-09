using System;
using System.ServiceModel;

namespace ServidorTareas
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(TareaService)))
            {
                host.Open();
                Console.WriteLine("Servidor iniciado en http://localhost:8080/TareasService");
                Console.WriteLine("Presiona cualquier tecla para detener el servidor...");
                Console.ReadKey();
            }
        }
    }
}
