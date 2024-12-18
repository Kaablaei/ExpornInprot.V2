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
        public ObservableCollection<RowData> FixedRows { get; set; }
        public AsnadeHeabdari_UserContoller(ICodingKollRepository ripo)
        {
            InitializeComponent();

            _ripo = ripo;

            FixedRows = new ObservableCollection<RowData>();
            for (int i = 0; i < 30; i++)
            {
                FixedRows.Add(new RowData { RowNumber = i + 1 }); // مقداردهی شماره ردیف
            }

            DataContext = this;

        }





        public class RowData
        {
            public int RowNumber { get; set; } // شماره ردیف
            public string KollCode { get; set; }
            public string MoeinCode { get; set; }
            public string Tafsili { get; set; }
            public string Description { get; set; }
            public decimal Debit { get; set; }
            public decimal Credit { get; set; }
        }

    }
}


