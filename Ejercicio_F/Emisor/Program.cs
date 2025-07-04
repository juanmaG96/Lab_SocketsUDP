using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Uso: EnviarMensaje <host> <puerto> <mensaje>");
            return;
        }
        try
        {
            // obtener parametros
            string host = args[0];
            int port = int.Parse(args[1]);
            string mensajeTexto = args[2];

            // crear objeto Mensaje
            Mensaje mensaje = new Mensaje(mensajeTexto);

            // crear socket UDP
            using UdpClient udpClient = new UdpClient();
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(host), port);

            // convertir mensaje a bytes y enviar
            byte[] datos = mensaje.ToArrayBytes();
            udpClient.Send(datos, datos.Length, remoteEndPoint);

            Console.WriteLine($"Mensaje enviado a {host}:{port}: {mensaje.Contenido}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return;
        }
    }
}