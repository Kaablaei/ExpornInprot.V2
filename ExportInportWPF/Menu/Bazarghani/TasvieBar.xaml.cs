using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static ExportInportWPF.Menu.hesabdari.AsnadeHeabdari_UserContoller;

namespace ExportInportWPF.Menu.Bazarghani
{
    /// <summary>
    /// Interaction logic for TasvieBar.xaml
    /// </summary>
    public partial class TasvieBar : UserControl
    {
        public ObservableCollection<ObservableCollection<string>> HorizontalData { get; set; }

        public TasvieBar()
        {
            InitializeComponent();
            var data = new List<RowData>
    {
        new RowData { RowNumber = 1, KollCode = "101", MoeinCode = "201", Tafsili = "تفصیلی 1", Description = "شرح 1", Debit = 1000, Credit = 500 },
        new RowData { RowNumber = 2, KollCode = "102", MoeinCode = "202", Tafsili = "تفصیلی 2", Description = "شرح 2", Debit = 1500, Credit = 800 }
    };

            // تغییر داده‌ها به حالت افقی
            HorizontalData = TransposeData(data);

            DataContext = this;
        }


        public static ObservableCollection<ObservableCollection<string>> TransposeData(List<RowData> source)
        {
            var result = new ObservableCollection<ObservableCollection<string>>();

            // استخراج مقادیر ستون‌ها
            var properties = typeof(RowData).GetProperties();

            foreach (var property in properties)
            {
                var row = new ObservableCollection<string> { property.Name }; // عنوان ستون
                foreach (var item in source)
                {
                    row.Add(property.GetValue(item)?.ToString() ?? "");
                }
                result.Add(row);
            }

            return result;
        }



    }
}
