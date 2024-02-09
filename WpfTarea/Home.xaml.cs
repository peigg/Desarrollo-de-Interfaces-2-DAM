using System.Windows.Controls;

namespace WpfTarea
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // View Expense Report
            Report expenseReportPage = new Report(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);

        }


    }
}
