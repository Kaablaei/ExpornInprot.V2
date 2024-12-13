using DataAcssesLayer.Repositoryes.InterFases;
using Domain;
using System.Windows;
using System.Windows.Controls;


namespace ExportInportWPF.Menu.Tarif
{
    /// <summary>
    /// Interaction logic for Kala_Tarif_userControll.xaml
    /// </summary>
    public partial class Kala_Tarif_userControll : UserControl
    {
        private IkalaRepository _ripo;
        public Kala_Tarif_userControll(IkalaRepository ripo)
        {
            InitializeComponent();
            _ripo = ripo;

            KalaDataGrid.ItemsSource = _ripo.GetAll();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(CodeKale.Text); 

            int kollId = id / 1000000; 
            int moinId = id / 1000;   

           
            var kala = new Kala
            {
                Id = id, 
                KollId = kollId, 
                MoinId = moinId, 
                KalName = KalaName.Text, 
              
                Weight = Convert.ToInt32(Weight.Text), 
                VahedMoayan = VahedMoayan.Text,
                Vahedjoz = Vahedjoz.Text,
                MabnayeMohasebat = Convert.ToInt32(MabnayeMohasebat.Text) 
            };


       
            _ripo.Add(kala);

            KalaDataGrid.ItemsSource = _ripo.GetAll();
        }
    }
}
