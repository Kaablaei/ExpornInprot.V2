using DataAcssesLayer.Repositoryes.InterFases;
using DataAcssesLayer;
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
using System.Collections.ObjectModel;

namespace ExportInportWPF.Menu.hesabdari
{
    /// <summary>
    /// Interaction logic for AsnadeHeabdari_UserContoller.xaml
    /// </summary>
    public partial class AsnadeHeabdari_UserContoller : UserControl
    {

        private ICodingKollRepository _ripo;
        public AsnadeHeabdari_UserContoller(ICodingKollRepository ripo)
        {
            InitializeComponent();




            Accounts = new ObservableCollection<Account>();
            Koll_DataGrid.ItemsSource = Accounts;
            _ripo = ripo;

        }

        private void Koll_DataGrid_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {

            if (e.Column.DisplayIndex == 0)
            {
                Koll_ListBox.ItemsSource = _ripo.GetAll();
                Koll_Popup.IsOpen = true;
            }



        }


        // تعریف لیست اصلی
        private List<CodeingKoll> _originalItems;


        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // موقعیت فعلی TextBox
                var point = textBox.GetRectFromCharacterIndex(textBox.CaretIndex, true).BottomLeft;

                // تبدیل به مختصات کلی پنجره
                var transform = textBox.TransformToVisual(this);
                var popupPosition = transform.Transform(point);

                // تنظیم موقعیت Popup
                Koll_Popup.HorizontalOffset = popupPosition.X;
                Koll_Popup.VerticalOffset = popupPosition.Y;

                // باز کردن Popup
                Koll_Popup.IsOpen = true;

                // فیلتر کردن لیست
                string filterText = textBox.Text.ToLower();
                if (!string.IsNullOrWhiteSpace(filterText) && _originalItems != null)
                {
                    Koll_ListBox.ItemsSource = _originalItems
                        .Where(item => item.CodeKoll.ToString().StartsWith(filterText))
                        .ToList();
                }
            }
        }


        private void Koll_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Koll_ListBox.SelectedItem != null)
            {
                var selectedItem = Koll_ListBox.SelectedItem;

                // گرفتن آیتم انتخاب‌شده در DataGrid
                var currentRow = Koll_DataGrid.SelectedItem as Account;
                if (currentRow != null)
                {
                    // مقداردهی کد کل
                    currentRow.KollCode = selectedItem.GetType().GetProperty("CodeKoll")?.GetValue(selectedItem)?.ToString();
                }

                // بستن Popup
                Koll_Popup.IsOpen = false;
                Koll_ListBox.SelectedItem = null;
                FilterTextBox.Text = string.Empty;

                // بازگرداندن فوکوس به سلول فعلی DataGrid
                Koll_DataGrid.BeginEdit();
            }
        }



        public ObservableCollection<Account> Accounts { get; set; }





        public class Account
        {
            public string KollCode { get; set; }
            public string MoeinCode { get; set; }
            public string Tafsili { get; set; }
            public string Description { get; set; }
            public decimal Credit { get; set; }
            public decimal Debit { get; set; }
        }
    }
}


