using System.Windows;
using System.Windows.Media.Imaging;

namespace Tarea9_POO_PabloGuerrero
{
    /// <summary>
    /// Lógica de interacción para Credits.xaml
    /// </summary>
    public partial class Credits : Window
    {
        private login.TipoPersonaje tipoPersonaje;
        private string imagenExploradorPath;
        public Credits(login.TipoPersonaje tipoPersonaje, string imagenExploradorPath)
        {
            InitializeComponent();

            this.tipoPersonaje = tipoPersonaje;
            this.imagenExploradorPath = imagenExploradorPath;

            // Crear un objeto BitmapImage utilizando la ruta de la imagen
            BitmapImage bitmapImage = new BitmapImage(new Uri(imagenExploradorPath, UriKind.Relative));

            // Asignar el BitmapImage al Source de imagenExplorador
            imagenExplorador.Source = bitmapImage;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
