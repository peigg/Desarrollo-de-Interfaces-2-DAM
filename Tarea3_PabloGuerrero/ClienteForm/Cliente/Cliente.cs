using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Cliente
{
    public partial class formCliente : Form
    {
        //inicializamos el form al ejecutar la app
        public formCliente()
        {
            InitializeComponent();
        }

        //Socket del cliente
        Socket cliente = null; 
        string ip = string.Empty;
        int puerto = 1200;

        //Función del botón conectar, conexion con el server
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            // Obtenemos la ip y el puerto, introducimos en la interfaz ip 127.0.0.1 , puerto 8888
            ip = txtIP.Text; 
            int.TryParse(TxtPuerto.Text, out puerto);

            try
            {
                // Se crea un nuevo objeto Socket llamado 'cliente' configurado para trabajar con conexiones de red IPv4 (InterNetwork),
                // de tipo flujo (Stream), y utilizando el protocolo TCP.
                cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Intenta establecer una conexión con la dirección IP y el puerto especificados.
                cliente.Connect(ip, puerto);

                // Se actualiza el título del formulario para reflejar que se ha establecido una conexión con la dirección IP y el puerto indicados.
                this.Text = string.Format("Conectado a {0}:{1}", ip, puerto);


                MessageBox.Show("Conectado.");

                //Estado para el cliente actual y se inicia la recepción de datos forma asíncrona (BeginReceive).
                Estado estado = new Estado();
                estado.socket = cliente;
                cliente.BeginReceive(estado.buffer, 0, Estado.buffersize, SocketFlags.None, new AsyncCallback(RecibirMensaje), estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        // Función para recibir mensajes del server
        private void RecibirMensaje(IAsyncResult resultado)
        {
            Estado estado = (Estado)resultado.AsyncState;
            Socket handler = estado.socket;

            //Se intenta leer datos del servidor y se muestra el mensaje recibido en un cuadro de texto en la interfaz gráfica.
            try
            {
                // Intenta finalizar la operación de recepción asincrónica y obtiene la cantidad de bytes recibidos.
                int i = handler.EndReceive(resultado);

                // Convierte los bytes recibidos en una cadena de caracteres utilizando ASCII encoding.
                string datos = Encoding.ASCII.GetString(estado.buffer, 0, i);

                // Utiliza Invoke para asegurarse de que la actualización del cuadro de texto se realice en el hilo de la interfaz de usuario.
                this.Invoke(new MethodInvoker(delegate ()
                {
                    // Agrega los datos recibidos al cuadro de texto, con una nueva línea para mejorar la legibilidad.
                    this.RtxtPanelMensajes.AppendText(datos + Environment.NewLine);
                }));

                // Reinicia la operación de recepción asincrónica (BeginReceive) para estar listo para futuros datos.
                cliente.BeginReceive(estado.buffer, 0, Estado.buffersize, SocketFlags.None, new AsyncCallback(RecibirMensaje), estado);


            }
            catch (SocketException)
            {
                MessageBox.Show("Conexión con el servidor perdida.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Función botón enviar
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            // Obtiene el mensaje del cuadro de texto en la interfaz de usuario.
            string mensaje = TxtMensaje.Text;

            // Convierte el mensaje en una secuencia de bytes utilizando ASCII encoding y lo envía al servidor
            // mediante el método Send del objeto Socket asociado al cliente.
            cliente.Send(Encoding.ASCII.GetBytes(mensaje));

            // Utiliza Invoke para asegurarse de que la actualización del cuadro de texto se realice en el hilo de la interfaz de usuario.
            this.Invoke(new MethodInvoker(delegate ()
            {
                // Limpia el cuadro de texto para prepararlo para futuros mensajes.
                this.TxtMensaje.Text = "";
            }));


        }
    }
    public class Estado
    {
        public Socket socket = null;
        public const int buffersize = 1024;
        public byte[] buffer = new byte[buffersize];
    }
}
