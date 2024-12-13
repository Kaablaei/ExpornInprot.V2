using DataAcssesLayer.Repositoryes.InterFases;
using Domain;
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
    /// Interaction logic for Irani_Driver_Mun_UserContoller.xaml
    /// </summary>
    public partial class Irani_Driver_Mun_UserContoller : UserControl
    {
        private IDriversRepository _ripo;
        public Irani_Driver_Mun_UserContoller(IDriversRepository ripo)
        {
            InitializeComponent();
            _ripo = ripo;
            DriversDataGrid.ItemsSource = _ripo.GetIrani();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(DriverId.Text);

            int kollId = id / 1000000;
            int moinId = id / 1000;

            var nerDriver = new Drivers
            {
                Id = id,
                KollId = kollId,
                MoinId = moinId,
                CarNumber = CarNumber.Text,
                DriverName = DriverName.Text,
                IsIraqi= false,
                PhoneNumber = PhoneNumber.Text
                


            };
            _ripo.Add(nerDriver);

            DriversDataGrid.ItemsSource = _ripo.GetIrani();



        }
    }
}
