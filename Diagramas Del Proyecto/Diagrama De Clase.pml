@startuml
Title Diagrama De Clase
class Tarea {
  - id
  - titulo
  - descripcion
  - estado
  + crearTarea
  + modificarTarea
  + eliminarTarea
}

class Usuario {
  - id
  - nombre
  - email
  + autenticar
  + gestionarTareas
}

class Sistema {
  + procesarSolicitud
}

Usuario -- Tarea : "gestiona"
Sistema -- Usuario : "autentica"
@enduml
