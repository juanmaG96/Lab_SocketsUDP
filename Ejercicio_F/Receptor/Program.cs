using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Uso: RecibirMensaje <puerto>");
            return;
        }

        try
        {
            // obtener puerto
            int port = int.Parse(args[0]);

            // crear socket UDP
            using UdpClient udpServer = new UdpClient(port);
            Console.WriteLine($"Escuchando en el puerto {port}...");

            while (true)
            {
                // recibir datagrama
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] buffer = udpServer.Receive(ref remoteEndPoint);

                // convertir a objeto Mensaje
                Mensaje mensaje = Mensaje.ToMessage(buffer);

                // Mostrar mensaje
                Console.WriteLine($"Mensaje recibido de {remoteEndPoint.Address}:{mensaje.Contenido}");                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return;
        }
    }
}