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
    /// Interaction logic for City_menu_UserController.xaml
    /// </summary>
    public partial class City_menu_UserController : UserControl
    {
        private ICityripository _ripo;
        public City_menu_UserController(ICityripository ripo)
        {
            InitializeComponent();
            _ripo = ripo;
            CityDataGrid.ItemsSource = _ripo.GetAll();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {


            _ripo.Add(new City
            {
                CityId = int.Parse(CityId.Text),
                CityName = CityName.Text,
                Distance = Citydistance.Text

            });

            Citydistance.Clear();
            CityName.Clear();
            CityId.Clear();
            CityDataGrid.ItemsSource = _ripo.GetAll();

        }

        private void CityDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
