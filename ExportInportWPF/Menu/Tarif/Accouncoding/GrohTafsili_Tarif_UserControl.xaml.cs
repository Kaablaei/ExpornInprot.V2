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
        private void SavePopup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int code;
                if (!int.TryParse(Popup_Code.Text, out code))
                {
                    MessageBox.Show("کد گروه تفصیلی باید یک عدد معتبر باشد.", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                string name = Popup_Name.Text;

                var existingItem = _ripo.GetAll().FirstOrDefault(p => p.Code == code);
                if (existingItem == null)
                {
                    MessageBox.Show("رکورد مورد نظر یافت نشد.", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // اعمال تغییرات به شیء انتخابی
                existingItem.Name = name;

                // به‌روزرسانی در پایگاه داده
                _ripo.Edit(existingItem);

                // به‌روزرسانی DataGrid
                GrohtasiliName.ItemsSource = _ripo.GetAll();

                // بستن Popup
                EditPopup.IsOpen = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطایی رخ داده است: {ex.Message}", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
        private void CancelPopup_Click(object sender, RoutedEventArgs e)
        {
            
            EditPopup.IsOpen = false;
        }

        private void GrohtasiliName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedItem = GrohtasiliName.SelectedItem as CodingGrohTafsili;
            if (selectedItem == null) return;

        
            Popup_Code.Text = selectedItem.Code.ToString();
            Popup_Name.Text = selectedItem.Name;

   
            EditPopup.IsOpen = true;
        }
      

    }
}
