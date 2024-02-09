using System.Windows;

namespace Tarea9_POO_PabloGuerrero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer;
        private login login;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            login = new login();
            timer = new Timer(TimerCallback, null, 3000, Timeout.Infinite); // Establecer un lapso de 3 segundos
        }

        private void TimerCallback(object state)
        {
            // Este método se llamará después de 3 segundos
            Application.Current.Dispatcher.Invoke(() =>
            {
                login.Show();  // Mostrar el formulario Login
                this.Close();
            });

            timer.Dispose(); // Liberar el temporizador después de su uso
        }
    }
}
