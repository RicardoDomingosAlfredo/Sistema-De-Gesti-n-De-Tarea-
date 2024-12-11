@startuml
Title Diagrama de Flujo
start
:Selecciona una opción;
if (¿Opción Crear?) then (Sí)
  :Usuario ingresa descripción de la tarea;
  :Guarda tarea en la base de datos;
else
  if (¿Opción Modificar?) then (Sí)
    :Usuario selecciona una tarea para modificar;
    :Actualiza la descripción en la base de datos;
  else
    if (¿Opción Eliminar?) then (Sí)
      :Usuario selecciona una tarea para eliminar;
      :Elimina tarea de la base de datos;
    else
      if (¿Opción Ver?) then (Sí)
        :Lista todas las tareas disponibles;
      endif
    endif
  endif
endif
stop
@enduml
