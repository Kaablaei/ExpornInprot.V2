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

                Koll_listBox.ItemsSource = _ripo.GetAll();
                Koll_Pupop.IsOpen = true;
            }

      

        }




        public ObservableCollection<Account> Accounts { get; set; }


        private void Koll_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Koll_listBox.SelectedItem != null)
            {
                var selectedItem = Koll_listBox.SelectedItem as Account;
                var dataGridRow = Koll_DataGrid.SelectedItem as Account;
                dataGridRow.KollCode = selectedItem.KollCode;  // انتقال کد کل به سلول
                Koll_Pupop.IsOpen = false;  // بستن پاپ‌آپ
                Koll_DataGrid.SelectedIndex += 1;  // حرکت به ستون بعدی
            }
        }

     
    }


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


