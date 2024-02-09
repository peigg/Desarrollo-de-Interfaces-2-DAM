using System;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Collections;



namespace Servidor_BINGO
{

    class Program
    {

        public static Hashtable lista_clientes = new Hashtable();
        public static int gan = new int();

        static void Main(string[] args)
        {
            String opc, modo;
            int jugadores, tipo;
            Console.WriteLine("______________________________________________");
            Console.WriteLine("           Bienvenido al Juego del            ");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("        ___                ___                ");
            Console.WriteLine("       |   |   *    ___   |___     ___        ");
            Console.WriteLine("       |---|   |   |   |  |   |   |   |       ");
            Console.WriteLine("       |___|   |   |   |  |___|   |___|       ");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Elija la cantidad de jugadores: ");
            opc = Console.ReadLine();
            while (opc == "1")
            {
                Console.WriteLine("1 no es un numero valido de jugadores: ");
                opc = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Elija el modo de Juego: ");
            Console.WriteLine("_________________________");
            Console.WriteLine("");
            Console.WriteLine("1)En Fila Horizontal ");
            Console.WriteLine("2)En Fila Vertical");
            Console.WriteLine("3)En Forma de T");
            Console.WriteLine("4)En Diagonal de izq - der");
            Console.WriteLine("5)En Diagonal de der - izq");
            Console.WriteLine("6)Carton LLeno");
            Console.WriteLine("7)En 4 Esquinas");
            Console.WriteLine("");
            modo = Console.ReadLine();
            tipo = int.Parse(modo);
            while (tipo < 1 || tipo > 7)
            {
                Console.WriteLine("No es una opcion valida: ");
                modo = Console.ReadLine();
                tipo = int.Parse(modo);
            }
            Console.WriteLine("________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");
            jugadores = int.Parse(opc);
            tipo = int.Parse(modo);

            System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(ip,8888);

            TcpClient clientSocket = default(TcpClient);

            int contador = 0;

            //
            IPAddress[] aryLocalAddr = null;
            String localhost = "";
            localhost = Dns.GetHostName();
            //IPHostEntry ipEntry = Dns.GetHostByName(localhost);
            IPHostEntry ipEntry = Dns.GetHostEntry(localhost);
            aryLocalAddr = ipEntry.AddressList;


            //


            serverSocket.Start();

            Console.WriteLine("Se ha iniciado el servidor, Escuchando en : {0}:8888", aryLocalAddr[1]);


            contador = 0;
            try
            {
                bool empieza = true;
                while (empieza == true)
                {
                    string nombre;
                    contador += 1;
                    string datos_cliente = null;
                    try
                    {
                        clientSocket = serverSocket.AcceptTcpClient();
                        byte[] bytesFrom = new byte[1024];
                       
                        NetworkStream networkStream = clientSocket.GetStream();
                        networkStream.Read(bytesFrom, 0, 1024);
                        //networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                        datos_cliente = System.Text.Encoding.ASCII.GetString(bytesFrom);
                        datos_cliente = datos_cliente.Substring(0, datos_cliente.IndexOf("$"));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.Source);
                    }



                   lista_clientes.Add(datos_cliente, clientSocket);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(datos_cliente + " Se ha conectado");
                    //Console.ReadKey();





                    handleClinet client = new handleClinet();


                    client.startClient(clientSocket, datos_cliente, lista_clientes);
                    nombre = datos_cliente;



                    intercambio_datos(datos_cliente + " se ha unido", datos_cliente, false);


                    if (lista_clientes.Count == jugadores)
                    {

                        serverSocket.Stop();
                        if (tipo == 1) { intercambio_datos("H1", datos_cliente, false); }
                        if (tipo == 2) { intercambio_datos("H2", datos_cliente, false); }
                        if (tipo == 3) { intercambio_datos("T1", datos_cliente, false); }
                        if (tipo == 4) { intercambio_datos("D1", datos_cliente, false); }
                        if (tipo == 5) { intercambio_datos("D2", datos_cliente, false); }
                        if (tipo == 6) { intercambio_datos("Bi", datos_cliente, false); }
                        if (tipo == 7) { intercambio_datos("E1", datos_cliente, false); }

                        intercambio_datos(" Atencion el juego iniciara en aprox 10seg", datos_cliente, false);

                        intercambio_datos("", datos_cliente, false);
                        intercambio_datos("", datos_cliente, false);
                        System.Threading.Thread.Sleep(10000);
                        intercambio_datos("", datos_cliente, false);
                        intercambio_datos(" Comienza el Juego, mucha suerte!!! ", datos_cliente, false);
                        intercambio_datos("", datos_cliente, false);

                        juego();
                        intercambio_datos("El juego ha finalizado, gracias por Participar ", datos_cliente, false);
                        intercambio_datos("0", datos_cliente, false);
                        empieza = false;


                    }

                }


            }
            catch (Exception e)
            {
                Console.WriteLine("NO hay usuarios conectados");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);  
                System.Threading.Thread.Sleep(10000);
                clientSocket.Close();
                serverSocket.Stop();
            }




        }



        public static void intercambio_datos(string msg, string uName, bool flag)
        {
            try
            {
                foreach (DictionaryEntry Item in lista_clientes)
                {

                    TcpClient broadcastSocket;

                    broadcastSocket = (TcpClient)Item.Value;

                    NetworkStream broadcastStream = broadcastSocket.GetStream();

                    Byte[] broadcastBytes = null;






                    if (flag == true)
                    {

                        if (msg == "BINGO")
                        {
                            gan = 1;
                            broadcastBytes = Encoding.ASCII.GetBytes(msg + "!!! el ganador es  " + uName);

                        }
                        else
                        {
                            broadcastBytes = Encoding.ASCII.GetBytes(uName + " dijo : " + msg);
                        }
                    }


                    else
                    {

                        broadcastBytes = Encoding.ASCII.GetBytes(msg);

                    }




                    broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);

                    broadcastStream.Flush();

                }
            }
            catch { }
        }

        /////////////
        public static void juego()
        {
            try
            {
                int[] num = new int[75];
                Random r = new Random();
                int i = new int();
                int j = new int();
                int auxiliar = 0;
                int contador = 0;
                /// GENERA 
                for (i = 0; i < 74; i++)
                {
                    auxiliar = r.Next(1, 75);
                    bool continuar = false;

                    while (!continuar)
                    {
                        for (j = 0; j <= contador; j++)
                        {
                            if (auxiliar == num[j])
                            {
                                continuar = true;
                                j = contador;
                            }
                        }

                        if (continuar)
                        {
                            auxiliar = r.Next(1, 75);
                            continuar = false;
                        }
                        else
                        {
                            continuar = true;
                            num[contador] = auxiliar;
                            contador++;
                        }
                    }
                }

                for (i = 0; i < 75; i++)
                {

                    System.Threading.Thread.Sleep(10000);
                    foreach (DictionaryEntry Item in lista_clientes)
                    {

                        TcpClient broadcastSocket;

                        broadcastSocket = (TcpClient)Item.Value;

                        NetworkStream envio = broadcastSocket.GetStream();

                        Byte[] broadcastBytes = null;
                        broadcastBytes = Encoding.ASCII.GetBytes(Convert.ToString(num[i]));
                        envio.Write(broadcastBytes, 0, broadcastBytes.Length);
                        envio.Flush();

                        if (gan == 1)
                        {
                            i = 74;



                            break;
                        }

                    }
                }
                Console.WriteLine("Ya hay ganador ");
            }
            catch { }

        }



    }





    public class handleClinet
    {

        TcpClient clientSocket;

        string clNo;

        Hashtable lista_clientes;



        public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cLista)
        {

            this.clientSocket = inClientSocket;

            this.clNo = clineNo;

            this.lista_clientes = cLista;

            Thread ctThread = new Thread(para_chat);

            ctThread.Start();

        }



        private void para_chat()
        {

            int requestCount = 0;

            byte[] bytesFrom = new byte[1024];

            string datos_cliente = null;

            Byte[] sendBytes = null;

            string serverResponse = null;

            string rCount = null;

            requestCount = 0;



            try
            {
                while ((true))
                {


                    requestCount = requestCount + 1;

                    NetworkStream networkStream = clientSocket.GetStream();

                    networkStream.Read(bytesFrom, 0, 1024);

                    datos_cliente = System.Text.Encoding.ASCII.GetString(bytesFrom);

                    datos_cliente = datos_cliente.Substring(0, datos_cliente.IndexOf("$"));





                    rCount = Convert.ToString(requestCount);



                    Program.intercambio_datos(datos_cliente, clNo, true);
                }
            }
            catch
            {
                Program.intercambio_datos(" ya no juego", clNo, true);
                Console.WriteLine(clNo + " se ha desconectado");
                lista_clientes.Remove(clNo);
                if (lista_clientes.Count == 1)
                {
                    Program.intercambio_datos("Te quedaste Jugando Solo!!!", "", false);
                }
                if (lista_clientes.Count == 0)
                {
                    Console.WriteLine("NO hay usuarios conectados");
                    clientSocket.Close();
                    Environment.Exit(0);

                }
            }



        }

    }

}


