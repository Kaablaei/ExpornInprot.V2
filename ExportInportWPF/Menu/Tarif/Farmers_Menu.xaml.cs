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

namespace ExportInportWPF.Menu.Tarif
{
    /// <summary>
    /// Interaction logic for Farmers_Menu.xaml
    /// </summary>
    public partial class Farmers_Menu : UserControl
    {
        private IFarmerRipository _ripo;
        public Farmers_Menu(IFarmerRipository ripo)
        {
            InitializeComponent();
            _ripo = ripo;
            FarmersDataGrid.ItemsSource = _ripo.GetAll();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            int eachkilo = int.Parse(FarmerWeight.Text);

            int price = int.Parse(FarmerEachKiloPrice.Text);
            int x = price * eachkilo;

            _ripo.Add(new Domain.Farmers
            {
                Id = int.Parse(FarmerId.Text),
                price = x,
                Name = FarmerName.Text,
                autherprices = int.Parse(FarmerAutherPrices.Text),
                weight = int.Parse(FarmerWeight.Text),
                EachKiloPrice = eachkilo,
                sardkhaneprice = int.Parse(FarmerSardkhanePrice.Text) 
                ,
                Sarh = FarmerSarh.Text





            });
            FarmersDataGrid.ItemsSource = _ripo.GetAll();

        }

        private void FarmersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
