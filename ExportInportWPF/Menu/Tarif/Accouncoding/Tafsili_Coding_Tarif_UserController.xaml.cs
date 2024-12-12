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

namespace ExportInportWPF.Menu.Tarif.Accouncoding
{
    /// <summary>
    /// Interaction logic for Tafsili_Coding_Tarif_UserController.xaml
    /// </summary>
    public partial class Tafsili_Coding_Tarif_UserController : UserControl
    {
        private ICodingGrohTafsiriRepository _GrohtafdsiryRipo;
        private ICoingTafsiliRepository _ripo;
        public Tafsili_Coding_Tarif_UserController(ICodingGrohTafsiriRepository grohtafdsiryRipo, ICoingTafsiliRepository ripo)
        {
            InitializeComponent();
            _GrohtafdsiryRipo = grohtafdsiryRipo;
            _ripo = ripo;

            tafsili_grid.ItemsSource = _ripo.GetAll();
            TafsiliGroupListBox.ItemsSource = _GrohtafdsiryRipo.GetAll();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var selectedTafsili = TafsiliGroupListBox.SelectedItem as CodingGrohTafsili;
            if (selectedTafsili == null)
            {
                MessageBox.Show("لطفاً یک گروه تفصیلی انتخاب کنید");
                return;
            }

            // اعتبارسنجی کد وارد شده
            if (!int.TryParse(CodeTextBox.Text, out int codeTafsili))
            {
                MessageBox.Show("کد تفصیلی باید یک عدد معتبر باشد");
                return;
            }
            try
            {

                var newTafsili = new CodingTafsili
                {
                    CodeTafsili = codeTafsili,
                    TafsiliName = SharhTextBox.Text,
                    Explain = CodeMoinTextBox5.Text,
                    TafsiliStatusIaActive = rbActive.IsChecked == true,
                    GropTafsiliCode = selectedTafsili.Code,
                    GropTafsiliName = selectedTafsili.Name.ToString() 
                };

                _ripo.Add(newTafsili);

                SharhTextBox.Clear();
                CodeMoinTextBox5.Clear();

                CodeTextBox.Clear();
                TafsiliGroupListBox.UnselectAll();

                tafsili_grid.ItemsSource = _ripo.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا: {ex.Message}");
            }
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }




    }
}
