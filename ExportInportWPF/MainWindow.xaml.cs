using ExportInportWPF.Menu.Tarif;
using ExportInportWPF.Menu.Tarif.Accouncoding;
using Microsoft.Extensions.DependencyInjection;
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

namespace ExportInportWPF
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

        private void KOl_Coding_Menu(object sender, RoutedEventArgs e)
        {
            var kollCodingControl = App.ServiceProvider.GetRequiredService<Koll_Coding_Tarif_UserControl>();
            MainContents.Content = kollCodingControl;

        }
        private void Moin_Coding_Menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Moin_coding_Tarif_UserControler>();
            MainContents.Content = page;

        }

        private void GrohTafsili_Coding_Menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<GrohTafsili_Tarif_UserControl>();
            MainContents.Content = page;

        }


    }
}