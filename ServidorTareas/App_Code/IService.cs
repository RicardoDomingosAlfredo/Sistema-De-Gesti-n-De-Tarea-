using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

// Contrato do Serviço
[ServiceContract]
public interface ITareaService
{
    [OperationContract]
    string CrearTarea(Tarea tarea);

    [OperationContract]
    List<Tarea> ListarTareas();

    [OperationContract]
    string ModificarTarea(Tarea tarea);

    [OperationContract]
    string EliminarTarea(int id);
}

// Classe Tarea
[DataContract]
public class Tarea
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Titulo { get; set; }

    [DataMember]
    public string Descripcion { get; set; }

    [DataMember]
    public DateTime FechaCreacion { get; set; }

    [DataMember]
    public bool Completada { get; set; }
}
