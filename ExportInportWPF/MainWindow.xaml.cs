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

            var kollCodingControl = new Menu.Tarif.Accouncoding.Koll_Coding_Tarif_UserControl();

            // جایگزینی یوزرکنترول در گرید
            MainContent.Children.Clear(); // پاک کردن محتوای قبلی
            MainContent.Children.Add(kollCodingControl); // اضافه کردن یوزرکنترول جدید
        }
    }
}