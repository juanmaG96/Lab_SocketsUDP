// ** Ejercicio_A: Datagramas UDP **
// Armat un datagrama UDP y mostrar sus datos:
// - Host (IP)
// - Puerto
// - Datos 

using System;
using System.Net;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Uso: Ejercicio_A <host> <puerto> <mensaje>");
            return;
        }

        try
        {
            // Obtener parametros de la linea de comandso
            string host = args[0]; // Direccion IP (ejemplo: 127.0.0.1)
            int port = int.Parse(args[1]); // Puerto (ejemplo: 80)
            string datos = args[2]; // Mensaje a enviar (ejemplo: "Hola")

            // convirtiendo datos a bytes
            byte[] buffer = Encoding.UTF8.GetBytes(datos);

            // Crear endpoint para el datagrama
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(host), port);

            // Mostrar informacion del datagrama
            Console.WriteLine("Paquete UDP:");
            Console.WriteLine($"Direccion Internet: {remoteEndPoint.Address}");
            Console.WriteLine($"Datos como string: {datos}");
            Console.WriteLine($"Datos como bytes: {BitConverter.ToString(buffer)}");
            Console.WriteLine($"Longitud: {buffer.Length}");
            //Console.WriteLine($"OffSet: {buffer.get}")
            Console.WriteLine($"Puerto: {remoteEndPoint.Port}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}