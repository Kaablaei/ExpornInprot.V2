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
    /// Interaction logic for GrohTafsili_Tarif_UserControl.xaml
    /// </summary>
    public partial class GrohTafsili_Tarif_UserControl : UserControl
    {
        private ICodingGrohTafsiriRepository _ripo;
        public GrohTafsili_Tarif_UserControl(   ICodingGrohTafsiriRepository ripo)
        {
            InitializeComponent();
            _ripo = ripo;
            
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            GrohtasiliName.ItemsSource = _ripo.GetAll();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {

            var newGropTafsili = new CodingGrohTafsili
            {
                Code = int.Parse(CodeGrofTafsiliCode.Text),

                Name = CodeGrofTafsiliName.Text.ToString()
            };

            _ripo.Add(newGropTafsili);

            //refreshing 
            CodeGrofTafsiliCode.Clear();
            CodeGrofTafsiliName.Clear();

            GrohtasiliName.ItemsSource = _ripo.GetAll();

        }


        private void GrohtasiliName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
