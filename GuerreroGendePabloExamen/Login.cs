using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Workshop
{
    
    public partial class Login : Form
    {

        
        public Login()
        {
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string storedUsername = Properties.Settings.Default.Caja1;
            string storedSalt = Properties.Settings.Default.Caja3;

            if (cBox.Checked && txtUser.Text == "vigilante" &&  txtPassword.Text == "cuidadín"){

                ControlAsistencia control = new ControlAsistencia();
                control.Show();
                this.Close();

            }

            else if (cBox.Checked && !string.IsNullOrEmpty(storedUsername) && !string.IsNullOrEmpty(storedSalt))
            {
                string enteredPasswordHash = SecurityHash.CalculateHash(txtPassword.Text, storedSalt);

                if(txtUser.Text == storedUsername && enteredPasswordHash == Properties.Settings.Default.Caja2)

                {
                    ControlAsistencia control = new ControlAsistencia();
                    control.Show();
                    this.Close();
                }
                else
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("¡Wrong Password!");
                    customMessageBox.ShowDialog();
                }
            }
            else
            {
                this.Close();
                CustomMessageBox customMessageBox = new CustomMessageBox("¡You must register first!");
                customMessageBox.ShowDialog();
                Register registroForm = new Register();
                registroForm.Show();
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Cambiar la visibilidad de los caracteres de la contraseña
            txtPassword.UseSystemPasswordChar = checkBox1.Checked;
        }

        
    }    
}
