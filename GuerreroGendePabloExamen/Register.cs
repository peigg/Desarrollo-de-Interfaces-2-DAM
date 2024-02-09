using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Workshop
{
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar los campos
            if (ValidarCampos())
            {
                string salt = SecurityHash.GenerateSalt();
                // Mostrar un mensaje de éxito
                CustomMessageBox customMessageBox = new CustomMessageBox("User Registered");
                customMessageBox.ShowDialog();
                // Guardamos usuario(con persistencia)
                Properties.Settings.Default.Caja1 = txtUser.Text;
                Properties.Settings.Default.Caja2 = SecurityHash.CalculateHash(txtPassword.Text,salt);
                Properties.Settings.Default.Caja3 = salt;
                Properties.Settings.Default.Save();
                // Crear el objeto Usuario con los datos de los cuadros de texto
                User user = new User(comboBox1.Text, txtName.Text,txtSurname.Text,txtMail.Text,txtMobile.Text,
                dateEdad.Value);
                CustomMessageBox MessageBox = new CustomMessageBox("Comin back to login form");
                customMessageBox.ShowDialog();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                // Mostrar un mensaje de error
                CustomMessageBox customMessageBox = new CustomMessageBox("Please, complete every field correctly");
                customMessageBox.ShowDialog();
            }
        }

        private bool ValidarCampos()
        {
            // Realizar la validación de todos los campos según tus criterio

            //Validación nombre
            if (string.IsNullOrWhiteSpace(txtName.Text) || !txtName.Text.All(char.IsLetter))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Introduce a valid name");
                customMessageBox.ShowDialog();
                return false;
            }

            //Validación apellido
            if (string.IsNullOrWhiteSpace(txtSurname.Text) || !txtSurname.Text.All(char.IsLetter))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Introduce a valid surname");
                customMessageBox.ShowDialog();
                return false;
            }

            //Validación mail

            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (!Regex.IsMatch(txtMail.Text, emailPattern))
            {
                // Correo electrónico no válido
                CustomMessageBox customMessageBox = new CustomMessageBox("Introduce a valid mail");
                customMessageBox.ShowDialog();
                return false;

            }

            //Validación edad

            // Obtener la fecha de nacimiento desde el DateTimePicker
            DateTime fechaNacimiento = dateEdad.Value;

            // Calcular la edad en años
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            // Verificar si la edad está dentro de un rango válido
            if (edad < 0 || edad > 100)
            {
                // Edad no válida
                CustomMessageBox customMessageBox = new CustomMessageBox("Introduce a valid date of birth");
                customMessageBox.ShowDialog();
                return false;
            }

            //Validar numero movil

            string phonePattern = @"^\d{9}$"; // Suponiendo un formato de 9 dígitos
            if (!Regex.IsMatch(txtMobile.Text, phonePattern))
            {
                // Número de teléfono móvil no válido
                CustomMessageBox customMessageBox = new CustomMessageBox("Introduce a valid phone number");
                customMessageBox.ShowDialog();
                return false;
            }

            //Validación usuario 

            if (string.IsNullOrWhiteSpace(txtUser.Text) || txtUser.Text.Length < 3 || txtUser.Text.Length > 20 || !EsAlfanumerico(txtUser.Text))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Introduce a valid username(between 3 and 20 alphanumeric chars");
                customMessageBox.ShowDialog();
                return false;
            }

            //Validación contraseña

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 8 || !ContieneCaracterEspecial(txtPassword.Text) || !ContieneLetraMinuscula(txtPassword.Text) || !ContieneLetraMayuscula(txtPassword.Text) || !ContieneDigito(txtPassword.Text))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("¡Introduce a valid password (min. 8 chars, at least one uppercase letter, one lowercaseletter, one digit and one special char).");
                customMessageBox.ShowDialog();
                return false;
            }

            return true;
        }

        private bool EsAlfanumerico(string texto)
        {
            return texto.All(char.IsLetterOrDigit);
        }

        private bool ContieneCaracterEspecial(string texto)
        {
            return texto.Any(c => !char.IsLetterOrDigit(c));
        }

        private bool ContieneLetraMinuscula(string texto)
        {
            return texto.Any(char.IsLower);
        }

        private bool ContieneLetraMayuscula(string texto)
        {
            return texto.Any(char.IsUpper);
        }

        private bool ContieneDigito(string texto)
        {
            return texto.Any(char.IsDigit);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    } 
}

