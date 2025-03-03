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

namespace WpfAppVERIFICADIGIT
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

        //Commento aggiunto da gitHub
        
        private List<Partita> partite = new List<Partita>();
        private List<Libro> libri = new List<Libro>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
