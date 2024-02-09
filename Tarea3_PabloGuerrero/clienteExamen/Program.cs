using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ClienteConsola
{
    class Program
    {
        // Socket del cliente para la comunicación con el servidor
        static Socket cliente = null;

        // Dirección IP y puerto del servidor al que se conectará el cliente
        static string ip = string.Empty;
        static int puerto = 1200;

        // Evento manual para controlar la concurrencia al recibir mensajes
        static ManualResetEvent gestor = new ManualResetEvent(true);

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cliente de Consola");

            // Solicita al usuario que ingrese la dirección IP del servidor
            Console.Write("Ingrese la dirección IP del servidor: ");
            ip = Console.ReadLine();

            // Solicita al usuario que ingrese el puerto del servidor
            Console.Write("Ingrese el puerto del servidor: ");
            int.TryParse(Console.ReadLine(), out puerto);

            try
            {
                // Crea un nuevo objeto Socket para el cliente configurado para trabajar con conexiones de red IPv4 (InterNetwork),
                // de tipo flujo (Stream), y utilizando el protocolo TCP.
                cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Intenta establecer una conexión con la dirección IP y el puerto especificados.
                cliente.Connect(ip, puerto);

                // Informa al usuario que se ha establecido la conexión
                Console.WriteLine("Conectado al servidor en {0}:{1}", ip, puerto);

                // Estado para el cliente actual y se inicia la recepción de datos de forma asíncrona (BeginReceive).
                Estado estado = new Estado();
                estado.socket = cliente;
                cliente.BeginReceive(estado.buffer, 0, Estado.buffersize, SocketFlags.None, new AsyncCallback(RecibirMensaje), estado);

                // Bucle principal para permitir al usuario enviar mensajes desde la consola
                while (true)
                {
                    // Lee la entrada del usuario desde la consola
                    string mensaje = Console.ReadLine();

                    // Sale del bucle si el usuario ingresa una línea vacía
                    if (string.IsNullOrEmpty(mensaje))
                        break;

                    // Convierte el mensaje en una secuencia de bytes utilizando ASCII encoding y lo envía al servidor
                    // mediante el método Send del objeto Socket asociado al cliente.
                    cliente.Send(Encoding.ASCII.GetBytes(mensaje));
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones en caso de errores durante la ejecución
                Console.WriteLine(ex.ToString());
            }
        }

        // Método de devolución de llamada para manejar la recepción asincrónica de mensajes del servidor
        static void RecibirMensaje(IAsyncResult resultado)
        {
            Estado estado = (Estado)resultado.AsyncState;
            Socket handler = estado.socket;

            try
            {
                // Intenta finalizar la operación de recepción asincrónica y obtiene la cantidad de bytes recibidos.
                int i = handler.EndReceive(resultado);

                // Convierte los bytes recibidos en una cadena de caracteres utilizando ASCII encoding.
                string datos = Encoding.ASCII.GetString(estado.buffer, 0, i);

                // Utiliza Invoke para asegurarse de que la actualización se realice en el hilo de la interfaz de usuario.
                Console.WriteLine("Recibido del servidor: {0}", datos);

                // Reinicia la operación de recepción asincrónica (BeginReceive) para estar listo para futuros datos.
                handler.BeginReceive(estado.buffer, 0, Estado.buffersize, SocketFlags.None, new AsyncCallback(RecibirMensaje), estado);
            }
            catch (SocketException)
            {
                // Informa al usuario que la conexión con el servidor se ha perdido.
                Console.WriteLine("Conexión con el servidor perdida.");
                gestor.Set();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones en caso de errores durante la ejecución
                Console.WriteLine(ex.ToString());
            }
        }
    }

    // Clase para almacenar información sobre la comunicación con el servidor
    public class Estado
    {
        public Socket socket = null;
        public const int buffersize = 1024;
        public byte[] buffer = new byte[buffersize];
    }
}
