using Accessibility;
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
    /// Interaction logic for Koll_Coding_Tarif_UserControl.xaml
    /// </summary>
    public partial class Koll_Coding_Tarif_UserControl : UserControl
    {

        private ICodingKollRepository _ripo;
        public Koll_Coding_Tarif_UserControl(ICodingKollRepository ripo)
        {
            InitializeComponent();
            _ripo = ripo;
            Koll_DataGrid.ItemsSource = _ripo.GetAll();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            try
            {
               
                int codeKoll;
                if (!int.TryParse(CodeKol.Text, out codeKoll))
                {
                    MessageBox.Show("کد کل باید یک عدد معتبر باشد.", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                string kollName = NameKol.Text;
                string accountGroup = AccountGrop.Text;
                string sharh = Explain.Text;

                bool isActive = rbActive.IsChecked ?? false;


                CodeingKoll newCodeingKoll = new CodeingKoll
                {
                    CodeKoll = codeKoll,
                    KollName = kollName,
                    AccoungGrop = accountGroup,
                    AccountStatuseIsBebtor = isActive,
                    Explain = sharh
                };

                // اضافه کردن شیء به دیتابیس
                _ripo.Add(newCodeingKoll);
                
                

                // به‌روزرسانی DataGrid
               Koll_DataGrid.ItemsSource = _ripo.GetAll();

                // پاک کردن مقادیر کنترل‌ها
                CodeKol.Clear();
                NameKol.Clear();
                AccountGrop.Clear();
                rbActive.IsChecked = true;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطایی رخ داده است: {ex.Message}", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Koll_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
