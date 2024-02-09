using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

delegate void AddMessage(string sNewMessage);

namespace bingo_Sockets
{
    public partial class Form1 : Form
    {
        int cuenta = 0;
        int[] num = new int[25];
        int cont1 = new int();
        bool act = true;
        int ti = new int();
        int de = new int();
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        //string audio
        string voz = "";
        string voz_modo = "";
        
        //
        
        string readData = "";

        public string nombr;

        private void getMessage()
        { try
                {
            while (true)
            {
               
                    serverStream = clientSocket.GetStream();
                    int buffSize = 0;
                    byte[] inStream = new byte[1024];
                    buffSize = clientSocket.ReceiveBufferSize;
                    serverStream.Read(inStream, 0, 1024);
                    string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                    readData = "" + returndata;
                    msg();

                }
               
            }
        catch
        {
           // MessageBox.Show("El Servidor se ha cerrado, el juego se cerrara");
            Application.Exit();
            
            
        }
        }

        private void msg()
        {
            try
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(msg));
                else
                {
                    int i = new int();
                    bool resultado = int.TryParse(readData, out i);
                    string h1 = "H1"; //Horizontal
                    string h2 = "H2"; //Vertical
                    string t1 = "T1"; //En T
                    string d1 = "D1"; //Diagonal izq der 
                    string d2 = "D2"; //Diagonal der izq
                    string bi = "Bi"; //Carton lleno
                    string e1 = "E1"; //Esquinas
                    bool mod = true;
                    if (resultado == true)
                    {
                        voz = i + ".WAV";
                        audio(voz);
                        de++;
                        if (i < 10)
                        {
                            numeros.Text = "0" + readData;
                        }
                        else
                        {
                            numeros.Text = readData;
                        }
                        desactivar();
                        if (de == 76) { de = 74; }
                        numde.Text = "Numero " + de + " / " + "74";
                        cuenta++;
                        if (cuenta == 5) { ultimos.Items.Clear(); cuenta = 0; }
                        ultimos.Items.Add(numeros.Text);
                       
                    }
                    
                    
                    else
                    { ///////////////////////////////////////////////////////////
                      //
                        if (readData.Contains(h1) == true && mod == true)
                        { modo.Text = "Fila Horizontal"; mod = false; ti = 1; }

                        if (mod == false && readData.Contains(h1) == true)
                        {
                            readData = "modo de juego: Fila Horizontal";
                            voz_modo = h1 + ".WAV";
                        }
                        //
                        if (readData.Contains(h2) == true && mod == true)
                        { modo.Text = "Fila Vertical"; mod = false; ti = 2; }

                        if (mod == false && readData.Contains(h2) == true)
                        {
                            readData = "modo de juego: Fila Vertical";
                            voz_modo = h2 + ".WAV";
                        }
                        //
                        //
                        if (readData.Contains(t1) == true && mod == true)
                        { modo.Text = "En Forma de T"; mod = false; ti = 3; }

                        if (mod == false && readData.Contains(t1) == true)
                        {
                            readData = "modo de juego: En Forma de T";
                            voz_modo = t1 + ".WAV";
                        }
                        //
                        //
                        if (readData.Contains(d1) == true && mod == true)
                        { modo.Text = "Diagonal de Izq - Der"; mod = false; ti = 4; }

                        if (mod == false && readData.Contains(d1) == true)
                        {
                            readData = "modo de juego: Diagonal de Izq - Der";
                            voz_modo = d1 + ".WAV";

                        }
                        //
                        //
                        if (readData.Contains(d2) == true && mod == true)
                        { modo.Text = "Diagonal de Der - Izq"; mod = false; ti = 5; }

                        if (mod == false && readData.Contains(d2) == true)
                        {
                            readData = "modo de juego: Diagonal de Der - Izq";
                            voz_modo = d2 + ".WAV";
                        }
                        //
                        //
                        if (readData.Contains(bi) == true && mod == true)
                        { modo.Text = "Carton lleno"; mod = false; ti = 6; }

                        if (mod == false && readData.Contains(bi) == true)
                        {
                            readData = "modo de juego: Carton lleno";
                            voz_modo = bi + ".WAV";
                        }
                        //
                        //
                        if (readData.Contains(e1) == true && mod == true)
                        { modo.Text = "4 Esquinas"; mod = false; ti = 7; }

                        if (mod == false && readData.Contains(e1) == true)
                        {
                            readData = "modo de juego: 4 esquinas";
                            voz_modo = e1 + ".WAV";
                        }
                        //
                        
                        empezar();
                        ventana.Items.Add(readData);



                    } ///////////////////////////////////////////////////////////


                    //

                    //
                    continuar.Enabled = true;
                    usuario.Enabled = false;


                    mens.Enabled = true;
                    enviar.Enabled = true;
                    conecta.Enabled = false;
                    ip.Enabled = false;
                }
            }
            catch(Exception e) {
                MessageBox.Show(e.Message);
               
            }
        }
      
        private int[] CalcularNumeros()
        {

            Random r = new Random();

            int auxiliar = 0;
            int contador = 0;

            for (int i = 0; i < 25; i++)
            {
                auxiliar = r.Next(1, 76);
                bool continuar = false;

                while (!continuar)
                {
                    for (int j = 0; j <= contador; j++)
                    {
                        if (auxiliar == num[j])
                        {
                            continuar = true;
                            j = contador;
                        }
                    }

                    if (continuar)
                    {
                        auxiliar = r.Next(1, 76);
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

            burbuja();
            campos();
            return num;

        }
        public void burbuja()
        {
            try
            {
                int j = new int();
                int i = new int();
                int temp = new int();
                for (i = 0; i < 25; i++)
                {
                    for (j = 0; j < 25; j++)
                    {
                        if (num[i] < num[j])
                        {
                            temp = num[i];
                            num[i] = num[j];
                            num[j] = temp;
                        }
                    }
                }
            }
            catch { }

        }





        public void campos()
        {


            f1.Text = Convert.ToString(num[0]); f2.Text = Convert.ToString(num[1]);
            f3.Text = Convert.ToString(num[2]); f4.Text = Convert.ToString(num[3]);
            f5.Text = Convert.ToString(num[4]); f6.Text = Convert.ToString(num[5]);
            f7.Text = Convert.ToString(num[6]); f8.Text = Convert.ToString(num[7]);
            f9.Text = Convert.ToString(num[8]); f10.Text = Convert.ToString(num[9]);
            f11.Text = Convert.ToString(num[10]); f12.Text = Convert.ToString(num[11]);
            f13.Text = Convert.ToString(num[12]); f14.Text = Convert.ToString(num[13]);
            f15.Text = Convert.ToString(num[14]); f16.Text = Convert.ToString(num[15]);
            f17.Text = Convert.ToString(num[16]); f18.Text = Convert.ToString(num[17]);
            f19.Text = Convert.ToString(num[18]); f20.Text = Convert.ToString(num[19]);
            f21.Text = Convert.ToString(num[20]); f22.Text = Convert.ToString(num[21]);
            f23.Text = Convert.ToString(num[22]); f24.Text = Convert.ToString(num[23]);
        }
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcularNumeros();
          
        }

        private void conecta_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario.Text == "")
                {
                    MessageBox.Show("Debe introducir un nombre");
                }
                else
                {
                    clientSocket.Connect(ip.Text, 8888);
                    serverStream = clientSocket.GetStream();

                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(usuario.Text + "$");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();

                    Thread ctThread = new Thread(getMessage);
                    ctThread.Start();


                    msg();
                    elegir.Enabled = true;
                    CalcularNumeros();
                    
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido establecer la conexion");



            }
        }

    

        private void Jugar_Click(object sender, EventArgs e)
        {
            
            elegir.Enabled = false;
            tablero.Enabled = true;
            listos();
             Jugar.Enabled = false;
            
        }

        public void activos()
        {
            f1.Enabled = true; f2.Enabled = true; f3.Enabled = true; f4.Enabled = true; f5.Enabled = true; f6.Enabled = true;
            f7.Enabled = true; f8.Enabled = true; f9.Enabled = true; f10.Enabled = true; f11.Enabled = true; f12.Enabled = true;
            f13.Enabled = true; f14.Enabled = true; f15.Enabled = true; f16.Enabled = true; f17.Enabled = true; f18.Enabled = true;
            f19.Enabled = true; f20.Enabled = true; f21.Enabled = true; f22.Enabled = true; f23.Enabled = true; f24.Enabled = true;
        }
        public void activos1()
        {
            f1.Enabled = true; f2.Enabled = true; f3.Enabled = true; 
            f4.Enabled = true; f5.Enabled = true; f8.Enabled = true;
            f17.Enabled = true; f22.Enabled = true;
           
        }
        public void activos2()
        {
            f1.Enabled = true; f7.Enabled = true; f18.Enabled = true;
            f24.Enabled = true;
         
        }
        public void activos3()
        {
            f20.Enabled = true; f16.Enabled = true; f9.Enabled = true;
            f5.Enabled = true; 
        }
        public void activos4()
        {
            f1.Enabled = true; f5.Enabled = true; f20.Enabled = true; 
            f24.Enabled = true; 
        }
        private void continuar_Click_1(object sender, EventArgs e)
        {
            clientSocket.Close();
            Application.Exit();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(mens.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            mens.Clear();

           

        }
        public void obtener(Button nue)
        {
            try
            {
                //ti 1 = h1|| ti 2 = h2|| ti 3 = t1|| ti 4 = d1||ti 5 = d2 || ti 6 = bi ||t1 7 = e1||
                int j, k = new int();
                j = int.Parse(numeros.Text);
                k = int.Parse(nue.Text);
             
                if (k == j)
                {
                    nue.BackColor = Color.Orange;
                    nue.Enabled = false;

                }
                
                //Horizontal
                if (ti == 1)
                {

                    if (f1.BackColor == Color.Orange && f2.BackColor == Color.Orange && f3.BackColor == Color.Orange && f4.BackColor == Color.Orange && f5.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                    if (f6.BackColor == Color.Orange && f7.BackColor == Color.Orange && f8.BackColor == Color.Orange && f9.BackColor == Color.Orange && f10.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                    if (f11.BackColor == Color.Orange && f12.BackColor == Color.Orange && f13.BackColor == Color.Orange && f14.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                    if (f15.BackColor == Color.Orange && f16.BackColor == Color.Orange && f17.BackColor == Color.Orange && f18.BackColor == Color.Orange && f19.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                    if (f20.BackColor == Color.Orange && f21.BackColor == Color.Orange && f22.BackColor == Color.Orange && f23.BackColor == Color.Orange && f24.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }

                }
                //FIn Horizontal
                //Vertical
                if (ti == 2)
                {

                    if (f1.BackColor == Color.Orange && f6.BackColor == Color.Orange && f11.BackColor == Color.Orange && f15.BackColor == Color.Orange && f20.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                    if (f2.BackColor == Color.Orange && f7.BackColor == Color.Orange && f12.BackColor == Color.Orange && f16.BackColor == Color.Orange && f21.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                    if (f3.BackColor == Color.Orange && f8.BackColor == Color.Orange && f17.BackColor == Color.Orange && f22.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                    if (f4.BackColor == Color.Orange && f9.BackColor == Color.Orange && f13.BackColor == Color.Orange && f18.BackColor == Color.Orange && f23.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                    if (f5.BackColor == Color.Orange && f10.BackColor == Color.Orange && f14.BackColor == Color.Orange && f19.BackColor == Color.Orange && f24.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }

                }
                //FIn Vertical
                //en T
                if (ti == 3)
                {

                    if (f1.BackColor == Color.Orange && f2.BackColor == Color.Orange && f3.BackColor == Color.Orange && f4.BackColor == Color.Orange && f5.BackColor == Color.Orange && f8.BackColor == Color.Orange && f17.BackColor == Color.Orange && f22.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                }
                //FIn T
                //Diagonal izq der
                if (ti == 4)
                {

                    if (f1.BackColor == Color.Orange && f7.BackColor == Color.Orange && f18.BackColor == Color.Orange && f24.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                }
                //FIn Diagonal izq der
                //Diagonal der izq
                if (ti == 5)
                {

                    if (f20.BackColor == Color.Orange && f16.BackColor == Color.Orange && f9.BackColor == Color.Orange && f5.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                }
                //FIn Diagonal der izq
                //Carton LLeno
                if (ti == 6)
                {
                    if (k == j)
                    {
                        nue.BackColor = Color.Orange;
                        nue.Enabled = false;
                        cont1--;
                    }
                 

                    if (cont1 == 0)
                    {
                        win.Visible = true;
                        tablero.Enabled = false;
                    }
                }
                //FIn Carton Lleno
                //4 esquinas
                if (ti == 7)
                {

                    if (f1.BackColor == Color.Orange && f5.BackColor == Color.Orange && f20.BackColor == Color.Orange && f24.BackColor == Color.Orange)
                    { win.Visible = true; tablero.Enabled = false; }
                }
                //FIn 4 esquinas
            }
            catch { }
        }

        private void f5_Click(object sender, EventArgs e){obtener(f5);}

        private void f1_Click(object sender, EventArgs e){obtener(f1);}

        private void f2_Click(object sender, EventArgs e){obtener(f2);}

        private void f3_Click(object sender, EventArgs e){obtener(f3);}

        private void f4_Click(object sender, EventArgs e){obtener(f4);}

        private void f6_Click(object sender, EventArgs e){obtener(f6);}

        private void f7_Click(object sender, EventArgs e){obtener(f7);}

        private void f8_Click(object sender, EventArgs e){obtener(f8);}

        private void f9_Click(object sender, EventArgs e){obtener(f9);}

        private void f10_Click(object sender, EventArgs e){obtener(f10);}

        private void f11_Click(object sender, EventArgs e){obtener(f11);}

        private void f12_Click(object sender, EventArgs e){obtener(f12);}

        private void f13_Click(object sender, EventArgs e){obtener(f13);}

        private void f14_Click(object sender, EventArgs e){obtener(f14);}

        private void f15_Click(object sender, EventArgs e){obtener(f15);}

        private void f16_Click(object sender, EventArgs e){obtener(f16);}

        private void f17_Click(object sender, EventArgs e){obtener(f17);}

        private void f18_Click(object sender, EventArgs e){obtener(f18);}

        private void f19_Click(object sender, EventArgs e){obtener(f19);}

        private void f20_Click(object sender, EventArgs e){obtener(f20);}

        private void f21_Click(object sender, EventArgs e){obtener(f21);}

        private void f22_Click(object sender, EventArgs e){obtener(f22);}

        private void f23_Click(object sender, EventArgs e){obtener(f23);}

        private void f24_Click(object sender, EventArgs e){obtener(f24);}

      

        private void Form1_Load(object sender, EventArgs e)
        {
            cont1 = 24;
        }

        private void win_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("BINGO" + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            win.Enabled = false;
            numeros.Text = "00";
        }
        public void desactivar()
        {
            
            if (numeros.Text == "00")
            {
                tablero.Enabled = false;
            }
        }

        public void empezar()
        {
            if (modo.Text != "-" && act == true)
            {
                Jugar.Enabled = true;
                act = false;
              
            }
        }
        public void listos()
        {
         if (ti == 1 || ti == 2 || ti == 6)
            { activos(); }
            if (ti == 3)
            { activos1(); }
            if (ti == 4)
            {
                activos2();
            }
             if (ti == 5)
            {
                activos3();
            }
             if (ti == 7)
            {
                activos4();
            }
             audio(voz_modo);
        }
        public void audio(string numeros_voz)
        {

            System.Media.SoundPlayer sonido = new System.Media.SoundPlayer();
            sonido.SoundLocation = numeros_voz;
            sonido.Load();
            sonido.Play();

        }
     
        

       
    }
}
