using System.Text.RegularExpressions;
using System.Windows;

namespace Tarea9_POO_PabloGuerrero
{
    /// <summary>
    /// Lógica de interacción para login.xaml
    /// </summary>
    public partial class login : Window
    {
        public TipoPersonaje PersonajeSeleccionado { get; private set; }
        private string imagenExplorador;
        public login()
        {
            InitializeComponent();
        }

        public enum TipoPersonaje
        {
            Arquero,
            Mago,
            Guerrero
        }



        private void btnContinuar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string imagenExploradorPath = "";

            if (ValidarNombre(nombre) && (cBoxArcher.IsChecked == true || cBoxMague.IsChecked == true || cBoxWarr.IsChecked == true))
            {

                if (cBoxArcher.IsChecked == true)
                {
                    PersonajeSeleccionado = TipoPersonaje.Arquero;
                    imagenExploradorPath = "Imagenes/ImagenArquero.png";
                }
                else if (cBoxMague.IsChecked == true)
                {
                    PersonajeSeleccionado = TipoPersonaje.Mago;
                    imagenExploradorPath = "Imagenes/ImagenMago.png";
                }
                else if (cBoxWarr.IsChecked == true)
                {
                    PersonajeSeleccionado = TipoPersonaje.Guerrero;
                    imagenExploradorPath = "Imagenes/ImagenGuerrero.png";
                }

                Intro intro = new Intro(PersonajeSeleccionado, imagenExploradorPath);
                intro.Show();
                this.Close();
            }
            else
            {
                // El nombre no es válido, mostrar un mensaje de error o realizar otra acción
                MessageBox.Show("Debes introducir un nombre válido que contenga al menos 3 caracteres alfabéticos y seleccionar uno de los roles.");
            }
        }

        private bool ValidarNombre(string nombre)
        {
            // Validar que el nombre tenga al menos 3 caracteres alfabéticos
            return Regex.IsMatch(nombre, @"^[a-zA-Z]{3,}$");
        }
    }
}
