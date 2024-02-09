using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop
{
    public partial class StartForm : Form
    {
        private Timer timer;
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Configurar y comenzar el temporizador
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 3000; // 3 segundos
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Detener el temporizador
            timer.Stop();

            // Mostrar el formulario de inicio de sesión
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
