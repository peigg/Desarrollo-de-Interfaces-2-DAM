using System.Windows;
using System.Windows.Media.Imaging;

namespace Tarea9_POO_PabloGuerrero
{
    /// <summary>
    /// Lógica de interacción para Nudo.xaml
    /// </summary>
    public partial class Nudo : Window
    {
        private login.TipoPersonaje tipoPersonaje;
        private int numeroSecreto;
        private int intentosRestantes = 3;
        private string imagenExploradorPath;
        public Nudo(login.TipoPersonaje tipoPersonaje, string imagenExploradorPath)
        {
            InitializeComponent();

            Random random = new Random();
            numeroSecreto = random.Next(1, 11);

            // Mostrar los intentos restantes
            txtResultado.Text = $"Tienes {intentosRestantes} intentos.";

            this.tipoPersonaje = tipoPersonaje;
            this.imagenExploradorPath = imagenExploradorPath;


            // Crear un objeto BitmapImage utilizando la ruta de la imagen
            BitmapImage bitmapImage = new BitmapImage(new Uri(imagenExploradorPath, UriKind.Relative));

            // Asignar el BitmapImage al Source de imagenExplorador
            imagenExplorador.Source = bitmapImage;

            
        }

    

        private void btnAdivinar_Click(object sender, RoutedEventArgs e)
        {
            if (intentosRestantes > 0)
            {
                // Obtener el número ingresado por el jugador
                if (int.TryParse(txtNumero.Text, out int numeroIngresado))
                {
                    // Verificar si el número ingresado es igual al número secreto
                    if (numeroIngresado == numeroSecreto)
                    {
                        txtResultado.Text = "¡Felicidades! Has adivinado el número y has conseguido abrir la puerta.";
                        btnAdivinar.IsEnabled = false;
                        btnAdivinar.Visibility = Visibility.Collapsed;
                        btnContinuar.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        // Reducir el número de intentos restantes
                        intentosRestantes--;

                        // Mostrar una pista si el número es mayor o menor que el número secreto
                        if (numeroIngresado < numeroSecreto)
                        {
                            txtResultado.Text = $"Intenta con un número mayor. Te quedan {intentosRestantes} intentos.";
                        }
                        else
                        {
                            txtResultado.Text = $"Intenta con un número menor. Te quedan {intentosRestantes} intentos.";
                        }

                        // Limpiar el TextBox para el próximo intento
                        txtNumero.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa un número válido.");
                }
            }
            else
            {
                txtResultado.Text = $"¡Se acabaron tus intentos! El número secreto era {numeroSecreto}.";
                btnAdivinar.IsEnabled = false;

                GameOver gameOver = new GameOver();
                gameOver.Show();
                this.Close();
            }
        }

        private void btnContinuar_Click(object sender, RoutedEventArgs e)
        {
            Final final = new Final(tipoPersonaje,imagenExploradorPath);
            final.Show();
            this.Close();
        }
    }
}    
