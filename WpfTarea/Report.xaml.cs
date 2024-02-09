using System.Windows.Controls;

namespace WpfTarea
{
    /// <summary>
    /// Lógica de interacción para Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        public Report()
        {
            InitializeComponent();
        }


        // Custom constructor to pass expense report data
        public Report(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }


    }
}
