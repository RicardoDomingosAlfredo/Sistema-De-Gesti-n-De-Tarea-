@startuml
Title Diagrama de Objectos
object Tarea1 {
  id = 12345
  titulo = "Comprar libros"
  descripcion = "Es importante tener los libros para ayudarte con las clases "
  estado = "Pendiente"
}

object Tarea2 {
  id = 2345
  titulo = "Descargar pdf"
  descripcion = "Materiales para auxiliar en los estudos"
  estado = "En progreso"
}

object Usuario1 {
  id = 2024
  nombre = "Ricardo Alfredo"
}

Usuario1 -- Tarea1
Usuario1 -- Tarea2
@enduml
