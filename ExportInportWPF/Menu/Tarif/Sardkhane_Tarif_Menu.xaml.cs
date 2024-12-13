using DataAcssesLayer.Repositoryes.InterFases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExportInportWPF.Menu.Tarif.Accouncoding
{
    /// <summary>
    /// Interaction logic for Sardkhane_Tarif_Menu.xaml
    /// </summary>
    public partial class Sardkhane_Tarif_Menu : UserControl
    {
        private ISarfkhaneRipository _ripo;
        public Sardkhane_Tarif_Menu(ISarfkhaneRipository ripo)
        {
            InitializeComponent();
            _ripo = ripo;
            SardkhaneDataGrid.ItemsSource = _ripo.GetAll();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            _ripo.Add(new Domain.sardkhane
            {
                Address = SardkhaneAddress.Text
               ,
                Id = int.Parse(SardkhaneId.Text),
                Name = SardkhaneName.Text,
                PhoneNumber = SardkhanePhoneNumber.Text
            });
            SardkhaneDataGrid.ItemsSource = _ripo.GetAll();
        }
    }
}
