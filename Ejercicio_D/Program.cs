// ** Ejercicio D **
// Crear un socket UDP, "setear" el tamaño del buffer de envio y de recepcion,
// tambien activar el timeOUT del socket a 1000 ms
// imprimir el estado del socket

using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        try
        {
            // Crear sucket UDP y enlazarlo al puerto 11000
            // (puerto 11000 es un puerto comun para pruebas)
            UdpClient udpSocket = new UdpClient(11000);

            // Configurar tamañp del buffer de envio y recepcion
            int sendBufferSize = 8192; // Tamaño del buffer de envío
            int receiveBufferSize = 8192; // Tamaño del buffer de recepción
            udpSocket.Client.SendBufferSize = sendBufferSize;
            udpSocket.Client.ReceiveBufferSize = receiveBufferSize;

            // configurar timeout del socket (1000 ms)
            udpSocket.Client.ReceiveTimeout = 1000;

            // obtener info del socket
            IPEndPoint localEndPoint = (IPEndPoint)udpSocket.Client.LocalEndPoint;

            // imprimir el estado del socket
            Console.WriteLine("Estado del socket UDP:");
            Console.WriteLine($"Direccion local: {localEndPoint.Address}");
            Console.WriteLine($"Puerto local: {localEndPoint.Port}");
            Console.WriteLine($"Tamaño del buffer de envio: {udpSocket.Client.SendBufferSize} bytes");
            Console.WriteLine($"Tamaño del buffer de recepcion: {udpSocket.Client.ReceiveBufferSize} bytes");
            Console.WriteLine($"Timeout de recepcion: {udpSocket.Client.ReceiveTimeout} ms");
            Console.WriteLine($"Socket activo: {udpSocket.Client.Connected || udpSocket.Client.IsBound}");

            // Cerrar el socket
            udpSocket.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}