using System.Windows;
using System.Windows.Media.Imaging;

namespace Tarea9_POO_PabloGuerrero
{
    /// <summary>
    /// Lógica de interacción para Intro.xaml
    /// </summary>
    public partial class Intro : Window
    {
        private login.TipoPersonaje tipoPersonaje;
        private int tiradasRealizadas = 0;
        private string imagenExploradorPath;

        public Intro(login.TipoPersonaje tipoPersonaje, string imagenExploradorPath)
        {
            InitializeComponent();
            this.tipoPersonaje = tipoPersonaje;
            this.imagenExploradorPath = imagenExploradorPath;

            // Crear un objeto BitmapImage utilizando la ruta de la imagen
            BitmapImage bitmapImage = new BitmapImage(new Uri(imagenExploradorPath, UriKind.Relative));

            // Asignar el BitmapImage al Source de imagenExplorador
            imagenExplorador.Source = bitmapImage;

            imagenNPC.Source = new BitmapImage(new Uri("Imagenes/ImagenNPC.png", UriKind.Relative));
        }

        private int LanzarDado()
        {
            // Lógica para lanzar el dado del jugador (usando un generador de números aleatorios)
            Random random = new Random();
            int tirada = random.Next(1, 21); // NPC puede obtener números del 1 al 20

            switch (tipoPersonaje)
            {
                case login.TipoPersonaje.Arquero:
                    tirada += random.Next(0, 3);
                    break;
                case login.TipoPersonaje.Guerrero:
                    tirada += 2; // Sumar 2 a la tirada para el guerrero
                    break;
                    // No es necesario un caso predeterminado ya que el tipo de personaje está definido
            }

            return tirada;
        }

        private int LanzarDadoNPC()
        {
            Random random = new Random();
            int tiradaNPC = random.Next(1, 21); // NPC puede obtener números del 1 al 20

            switch (tipoPersonaje)
            {
                case login.TipoPersonaje.Mago:
                    // Restar 1 a la tirada del NPC para el mago
                    tiradaNPC -= 1;
                    break;
            }

            return tiradaNPC;
        }


        private void btnLanzarDados_Click(object sender, RoutedEventArgs e)
        {
            if (tiradasRealizadas < 3)
            {
                // Incrementar el contador de tiradas
                tiradasRealizadas++;
                // Realizar una tirada de dados para el jugador y para el NPC
                int resultadoJugador = LanzarDado();
                int resultadoNPC = LanzarDadoNPC();

                // Comparar los resultados y mostrar el resultado
                if (resultadoJugador > resultadoNPC)
                {
                    txtResultado.Text = $"Tu tirada: {resultadoJugador}\nTirada del NPC: {resultadoNPC}\n¡Has ganado! Puedes pasar a la siguiente pantalla.";
                    btnLanzarDados.Visibility = Visibility.Collapsed;
                    btnLanzarDados.IsEnabled = false;

                    btnContinuar.Visibility = Visibility.Visible; // Mostrar el botón Continuar
                }
                else
                {
                    txtResultado.Text = $"Tu tirada: {resultadoJugador}\nTirada del NPC: {resultadoNPC}\n¡El NPC ha ganado! Inténtalo de nuevo.";
                }

                // Si se han realizado tres tiradas y has perdido, deshabilitar el botón y paso a pantalla de game over
                if (tiradasRealizadas == 3)
                {

                    GameOver gameOver = new GameOver();
                    gameOver.Show();
                    this.Close();
                }
            }
        }

        private void btnContinuar_Click(object sender, RoutedEventArgs e)
        {
            Nudo nudo = new Nudo(tipoPersonaje, imagenExploradorPath);
            nudo.Show();
            this.Close();
        }
    }
}
