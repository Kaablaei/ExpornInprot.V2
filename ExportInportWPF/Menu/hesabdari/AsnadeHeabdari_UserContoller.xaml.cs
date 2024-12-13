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
        public AsnadeHeabdari_UserContoller()
        {
            InitializeComponent();
            InitializeComponent();

            // تنظیم لیست خالی برای DataGrid
            Accounts = new ObservableCollection<Account>();
            Koll_DataGrid.ItemsSource = Accounts;

      
        }
        

        public ObservableCollection<Account> Accounts { get; set; }


       
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


