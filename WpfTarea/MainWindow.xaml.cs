using System.Windows;

namespace WpfTarea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
                txtAviso.Text = "OK";
            }
            else
            {
                txtAviso.Text = "KO";
                Window1 vent = new Window1();
                vent.Show();
            }

        }
    }
}