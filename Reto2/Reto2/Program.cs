using System;
using System.Windows.Forms;

namespace Reto2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
        }
    }

    public partial class Form1 : Form
    {
        public void Form()
        {
            // Crear un botón
            Button miBoton = new Button();
            miBoton.Text = "Haz clic";
            miBoton.Size = new System.Drawing.Size(100, 30);
            miBoton.Location = new System.Drawing.Point(50, 50);
            miBoton.Click += MiBoton_Click;

            // Crear una etiqueta
            Label miEtiqueta = new Label();
            miEtiqueta.Text = "¡Hola, mundo!";
            miEtiqueta.Size = new System.Drawing.Size(200, 30);
            miEtiqueta.Location = new System.Drawing.Point(50, 100);

            // Agregar controles al formulario
            Controls.Add(miBoton);
            Controls.Add(miEtiqueta);

            // Configuraciones generales del formulario
            Text = "Ejemplo de Formulario";
            Size = new System.Drawing.Size(300, 200);
        }

        private void MiBoton_Click(object sender, EventArgs e)
        {
            // Cambiar el texto de la etiqueta al hacer clic en el botón
            ((Label)Controls[1]).Text = "¡Botón clicado!";
        }
    }
}
