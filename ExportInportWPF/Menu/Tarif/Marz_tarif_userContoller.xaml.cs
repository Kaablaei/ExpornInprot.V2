using DataAcssesLayer.Repositoryes;
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
    /// Interaction logic for Marz_tarif_userContoller.xaml
    /// </summary>
    public partial class Marz_tarif_userContoller : UserControl
    {
        private IBorderripository _ripo;
        public Marz_tarif_userContoller(IBorderripository ripo)
        {
            InitializeComponent();
            _ripo = ripo;
            BorderDataGrid.ItemsSource = _ripo.GetAll();
        }



        private void Button_Add(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(BorderId.Text);

            int kollId = id / 1000000;
            int moinId = id / 1000;

            _ripo.Add(new Domain.Border
            {
                Id = id,
                MoinId = moinId,
                KollId = kollId,
                BorderName = BorderName.Text,
                Borderdistance = Borderdistance.Text,
            });


            BorderDataGrid.ItemsSource = _ripo.GetAll();
        }

        private void BorderDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
