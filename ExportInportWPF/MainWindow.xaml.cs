using ExportInportWPF.Menu.hesabdari;
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
        private void IraniTarkhisKar(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<TarkhisKar_Irani_UserController>();
            MainContents.Content = page;

        }
        private void Iraqi_tarkhisKarmenu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Tarkhis_Iraqi_UserController>();
            MainContents.Content = page;

        }

        private void GrohTafsili_Coding_Menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<GrohTafsili_Tarif_UserControl>();
            MainContents.Content = page;

        }
        private void Tasili_Coding_Menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Tafsili_Coding_Tarif_UserController>();
            MainContents.Content = page;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AsnandeHesabdari_menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<AsnadeHeabdari_UserContoller>();
            MainContents.Content = page;
        }

        private void kalamenu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Kala_Tarif_userControll>();
            MainContents.Content = page;
        }


        private void IraqidRIVERS_menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<IraQi_Drivers_menu_UserConteolles>();
            MainContents.Content = page;
        }

        private void IraniDrivers_menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Irani_Driver_Mun_UserContoller>();
            MainContents.Content = page;
        }
        private void Sardkhane_menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Sardkhane_Tarif_Menu>();
            MainContents.Content = page;
        }
        private void farmer_menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Farmers_Menu>();
            MainContents.Content = page;
        }

        private void Customer(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Farmers_Menu>();
            MainContents.Content = page;
        }


        private void border_menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<Marz_tarif_userContoller>();
            MainContents.Content = page;
        }

       



        
        private void City_menu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<City_menu_UserController>();
            MainContents.Content = page;
        }

       
          
        private void BestanKar_Meenu(object sender, RoutedEventArgs e)
        {
            var page = App.ServiceProvider.GetRequiredService<BestanKar_Meenu_UserController>();
            MainContents.Content = page;
        }

       







        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // SelectKollWindow selectKollWindow = new SelectKollWindow();
            //selectKollWindow.ShowDialog();
        }
    }
}