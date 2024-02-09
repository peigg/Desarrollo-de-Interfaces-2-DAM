using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    internal class Program
    {
        // Flag que indica si el servidor está encendido
        static bool serverOn = false;

        // Almacena la dirección de los clientes conectados
        static Dictionary<string, Socket> clientList = new Dictionary<string, Socket>();

        // Evento manual para controlar la concurrencia al aceptar conexiones.
        static ManualResetEvent controller = new ManualResetEvent(true);

        static void Main(string[] args)
        {
            // Socket del servidor y establecemos la dirección IP y el número del puerto
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 8888);

            // Enlazamos el socket con la IP 
            serverSocket.Bind(ip);
            // Establecemos el tamaño máximo de la cola
            serverSocket.Listen(300);
            // Arrancamos el server
            serverOn = true;
            Console.WriteLine("¡Bienvenido al Servidor del Juego!");
            Console.WriteLine("Esperando conexiones en el puerto {0}...", ip.Port);

            // Bucle para aceptar múltiples clientes
            while (serverOn)
            {
                // Establece el evento manual en estado no señalizado.
                controller.Reset();

                // Inicia la operación asincrónica para aceptar una conexión de cliente.
                // El método AceptarCliente se ejecutará cuando se acepte la conexión.
                serverSocket.BeginAccept(new AsyncCallback(acceptClient), (Socket)serverSocket);

                // Espera hasta que el evento manual se señalice desde otro hilo.
                // Esto bloquea la ejecución hasta que se acepte una conexión.
                controller.WaitOne();
            }
        }

        // Clase para almacenar información sobre la comunicación con el cliente
        public class Info
        {
            // Socket de conexión asociado a este estado.
            public Socket socket = null;

            // Tamaño constante del búfer utilizado para la recepción de datos.
            public const int buffersize = 1024;

            // Búfer de bytes para almacenar los datos recibidos del cliente.
            public byte[] buffer = new byte[buffersize];

            // Dirección del cliente, inicializada como una cadena vacía.
            public string direccion = string.Empty;
        }

        // Método para aceptar clientes de forma manual con el controller
        static void acceptClient(IAsyncResult result)
        {
            // Socket asociando a nuestro server
            Socket server = (Socket)result.AsyncState;
            // dejamos de aceptar clientes y obtenemos el socket del cliente
            Socket listener = server.EndAccept(result); 
            

            string direccion = listener.RemoteEndPoint.ToString();
            // Agregamos al cliente a la lista
            clientList.Add(direccion, listener);
            

            Console.WriteLine("Cliente <{0}> conectado.", direccion);
            controller.Set();

            // Creamos un objeto Estado para el cliente actual
            Info estado = new Info();
            estado.socket = listener;
            estado.direccion = direccion;
            //iniciamos la recepción de datos de forma asíncrona
            listener.BeginReceive(estado.buffer, 0, Info.buffersize, SocketFlags.None, new AsyncCallback(MessageClient), estado);
            
        }

        // Método para recibir los mensajes de los clientes
        static void MessageClient(IAsyncResult resultado)
        {
            Info estado = (Info)resultado.AsyncState;
            Socket handler = estado.socket;

            try
            {
                int i = handler.EndReceive(resultado);

                string datos = string.Format("{0}: {1}", estado.direccion, Encoding.ASCII.GetString(estado.buffer, 0, i));
                Console.WriteLine("Recibido por {0}", datos);

                // Reiniciamos la operación de recepción para futuros datos
                handler.BeginReceive(estado.buffer, 0, Info.buffersize, SocketFlags.None, new AsyncCallback(MessageClient), estado);

                // Enviamos el mensaje a todos los clientes conectados
                foreach (Socket socket in clientList.Values)
                {
                    socket.Send(Encoding.ASCII.GetBytes(datos));
                }
            }
            catch (SocketException)
            {
                Console.WriteLine("Cliente <{0}> desconectado.", estado.direccion);
                // Elimina al cliente de la lista
                clientList.Remove(estado.direccion); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
