using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_lez01_Integrazione
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

        private void Saluta_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hai cliccato sul pulsante Ciao");
        }

        private void Chiusura_Evento(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}