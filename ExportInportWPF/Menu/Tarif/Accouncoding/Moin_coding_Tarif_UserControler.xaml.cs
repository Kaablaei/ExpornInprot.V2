using DataAcssesLayer;
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
    /// Interaction logic for Moin_coding_Tarif_UserControler.xaml
    /// </summary>
    public partial class Moin_coding_Tarif_UserControler : UserControl
    {

        private ICodingKollRepository _KolRipo;
        private ICodingGrohTafsiriRepository _GrohtafdsiryRipo;
        private ICodingMoinRepository _ripo;
        private string _nameKol; 
        private int _CodeeKol; 
        public Moin_coding_Tarif_UserControler(ICodingKollRepository KolRipo, ICodingGrohTafsiriRepository grohtafdsiryRipo, ICodingMoinRepository ripo)
        {
            InitializeComponent();
            _KolRipo = KolRipo;
            _GrohtafdsiryRipo = grohtafdsiryRipo;
            _ripo = ripo;
            Moin_grid.ItemsSource = _ripo.GetAll();
            TafsiliGroupListBox.ItemsSource = _GrohtafdsiryRipo.GetAll();
        }

        private void CodeMoin_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 3)
            {
                var codeMoin = textBox.Text.Substring(0, 3);
                var koll = GetKollByCode(int.Parse(codeMoin));
                
                if (koll != null)
                {
                    CodeKollTextBox.Text = koll.KollName.ToString();
                    _nameKol = koll.KollName.ToString();

                }
                else
                {
                    CodeKollTextBox.Text = string.Empty;
                }
            }
        }


        private CodeingKoll GetKollByCode(int code)
        {

            return _KolRipo.GetByCodeKoll(code);
        }

        private void RefreshMoinGrid()
        {
            CodeMoinTextBox.Clear();
            MoinNameTextBox.Clear();
            PhoneNumberTextBox.Clear();
            ExplainTextBox.Clear();
            CodeKollTextBox.Clear();
            CodeKollTextBox.Clear();
            TafsiliGroupListBox.UnselectAll();
            Moin_grid.ItemsSource = _ripo.GetAll();
        }


        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var selectedTafsili = TafsiliGroupListBox.SelectedItem as CodingGrohTafsili;
            if (selectedTafsili == null)
            {
                MessageBox.Show("لطفاً یک گروه تفصیلی انتخاب کنید");
                return;
            }


            var newMoin = new CodingMoind
            {
                CodeMoin = int.Parse(CodeMoinTextBox.Text),
                MoinName = MoinNameTextBox.Text,
                Phonenumber = PhoneNumberTextBox.Text,
                Expalein = ExplainTextBox.Text,
                StatuseIsActive = rbActive.IsChecked == true,
              // CodeKoll = 
                //KollName = _nameKol.ToString(),
                Adrees = "null",
                TafsiliGropId = selectedTafsili.Code,
                TafsiliGropName = selectedTafsili.Name
            };

            _ripo.Add(newMoin); // ذخیره در لیست یا دیتابیس
            RefreshMoinGrid(); // به‌روزرسانی DataGrid
        }

        // نمونه متد برای دریافت نام کل
  

       
       

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

   
    }
}
