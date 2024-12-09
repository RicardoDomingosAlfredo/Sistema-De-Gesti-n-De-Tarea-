using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServidorTareas
{
    // Define el contrato del servicio
    [ServiceContract]
    public interface ITareaService
    {
        [OperationContract]
        void CrearTarea(string nombre);

        [OperationContract]
        List<Tarea> ListarTareas();

        [OperationContract]
        void ModificarTarea(int id, string nuevoNombre);

        [OperationContract]
        void EliminarTarea(int id);
    }

    // Clase que representa una Tarea
    [DataContract]
    public class Tarea
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public DateTime FechaCreacion { get; set; }
    }
}
