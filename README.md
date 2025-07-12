# Práctico de Sockets UDP en C#

Trabajo práctico de la asignatura Redes de Información (4to año, Ingeniería en Sistemas de Información, UTN FRCU).

## Estructura del proyecto
- **EjercicioA**: Crear y mostrar un datagrama UDP con datos desde la línea de comandos.
- **EjercicioD**: Configurar un socket UDP con buffer y timeout.
- **EjercicioE**: Recibir datagramas UDP en el puerto 80.
- **EjercicioF**: Clase `Mensaje` y aplicaciones para enviar (`Emisor`) y recibir (`Receptor`) mensajes UDP.

## Requisitos
- .NET 8.0
- Git

## Instrucciones
1. Ejecutar cada ejercicio, por ejemplo:
   - Ejercicio A: `cd EjercicioA && dotnet run 127.0.0.1 80 hola`
   - Ejercicio F (receptor): `cd EjercicioF/Receptor && dotnet run 80`
   - Ejercicio F (emisor): `cd EjercicioF/Emisor && dotnet run 127.0.0.1 80 "Hola, mundo!"`
