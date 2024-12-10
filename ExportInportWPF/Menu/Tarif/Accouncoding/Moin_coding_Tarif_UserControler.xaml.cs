using DataAcssesLayer;
using DataAcssesLayer.Repositoryes;
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
        public Moin_coding_Tarif_UserControler(ICodingKollRepository KolRipo)
        {
            InitializeComponent();
            _KolRipo = KolRipo;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {

        }

        private CodeingKoll GetKollByCode(int code)
        {
            // اینجا می‌توانید کد مرتبط با دیتابیس یا یک لیست محلی را پیاده‌سازی کنید
            return _KolRipo.GetByCodeKoll(code);
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
                }
                else
                {
                    CodeKollTextBox.Text = string.Empty; 
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
