using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tarea9_POO_PabloGuerrero
{
    /// <summary>
    /// Lógica de interacción para Final.xaml
    /// </summary>
    public partial class Final : Window
    {

        private readonly string colorCorrecto = "Amarillo"; // Color correcto para abrir el cofre
        private readonly Random random = new Random();
        private int intentos = 2; // Intentos restantes

        private login.TipoPersonaje tipoPersonaje;
        private string imagenExploradorPath;
        public Final(login.TipoPersonaje tipoPersonaje, string imagenExploradorPath)
        {
            InitializeComponent();

            this.imagenExploradorPath = imagenExploradorPath;
            this.tipoPersonaje = tipoPersonaje;

            // Crear un objeto BitmapImage utilizando la ruta de la imagen
            BitmapImage bitmapImage = new BitmapImage(new Uri(imagenExploradorPath, UriKind.Relative));

            // Asignar el BitmapImage al Source de imagenExplorador
            imagenExplorador.Source = bitmapImage;

            ConfigurarColores();
        }

        private void ConfigurarColores()
        {
            // Lista de colores disponibles
            string[] colores = { "Rojo", "Azul", "Amarillo", "Verde" };

            // Barajar los colores
            for (int i = 0; i < colores.Length; i++)
            {
                int randomIndex = random.Next(i, colores.Length);
                string temp = colores[randomIndex];
                colores[randomIndex] = colores[i];
                colores[i] = temp;
            }

            // Crear botones para cada color
            foreach (string color in colores)
            {
                Button button = new Button
                {
                    Content = color,
                    Width = 100,
                    Height = 50,
                    Margin = new Thickness(20),
                    FontSize = 16,
                    FontWeight = FontWeights.Bold,
                    Background = new SolidColorBrush(Color.FromRgb(255, 255, 255)) // Fondo blanco
                };

                // Asignar evento al botón
                button.Click += ColorButtonClick;

                // Agregar el botón al contenedor de colores
                panelColores.Children.Add(button);
            }
        }

        private void ColorButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string colorSeleccionado = button.Content.ToString();

            if (colorSeleccionado == colorCorrecto)
            {
                // Abrir el cofre si el color seleccionado es correcto
                txtResultado.Text = $"Has acertado";

                panelColores.Visibility = Visibility.Collapsed;
                // Mostrar el botón Continuar
                btnContinuar.Visibility = Visibility.Visible;
            }
            else
            { // Decrementar los intentos restantes
                intentos--;

                if (intentos > 0)
                {
                    txtResultado.Text = $"Intentalo otra vez";
                }
                else
                {
                    GameOver gameOver = new GameOver();
                    gameOver.Show();
                    this.Close();
                }
            }
        }

        private void btnContinuar_Click(object sender, RoutedEventArgs e)
        {
            Credits credits = new Credits(tipoPersonaje, imagenExploradorPath);
            credits.Show();
            this.Close();
        }
    }
}
