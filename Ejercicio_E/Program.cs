// ** Ejercicio E ** 
// Crear un programa que lee en el puerto 80 de su host de paquetes UDP
// transformar los datos del array de bytes a string y mostrar el string por consola

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            // crear socket UDP y enlazarlo al puerto 80
            UdpClient udpServer = new UdpClient(80);
            Console.WriteLine("Escuchando en el puerto 80...");

            while (true)
            {
                // recibir datagrama
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] buffer = udpServer.Receive(ref remoteEndPoint);

                // convertir datos a string
                string datos = Encoding.UTF8.GetString(buffer);

                // mostrar datos recibidos
                Console.WriteLine($"Datos recibidos de {remoteEndPoint}:{datos}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}