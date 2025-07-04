// ** Ejercicio F **
// dato que Datagramsocket solo pueden enviar un array de bytes
// crear una clase Mensaje para encapsular los datos, 
// agregar a la clase un metodo ToArrayBytes() 
// y otro que recibe un array de bytes ToMessage(bytes[] datos) y retorna una clase Mensaje.
// luego utilizando la clase Mensaje realice dos aplicaciones una para enviar mensajes y otra para recibir mensajes.


using System;
using System.Text;

class Mensaje
{
    public string Contenido { get; set; }

    public Mensaje(string contenido)
    {
        Contenido = contenido;
    }
    // convertir el mensaje a array de bytes
    public byte[] ToArrayBytes()
    {
        return Encoding.UTF8.GetBytes(Contenido);
    }
    // crear un mensaje desde un array de bytes
    public static Mensaje ToMessage(byte[] datos)
    {
        string contenido = Encoding.UTF8.GetString(datos);
        return new Mensaje(contenido);
    }
}