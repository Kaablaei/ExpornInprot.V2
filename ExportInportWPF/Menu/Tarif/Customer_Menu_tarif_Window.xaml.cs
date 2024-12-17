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
using System.Windows.Shapes;

namespace ExportInportWPF.Menu.Tarif
{
    /// <summary>
    /// Interaction logic for Customer_Menu_tarif_Window.xaml
    /// </summary>
    public partial class Customer_Menu_tarif_Window : Window
    {
        private readonly int _cityCode;
        private ICustomerRipository _ripo;
        private ICityripository  cityripository;
        public Customer_Menu_tarif_Window(int cityCode , ICustomerRipository ripo)
        {


            InitializeComponent();
            _cityCode = cityCode;
            _ripo = ripo;
            var customers = _ripo.GetAll();
            CustomerGrid.ItemsSource = customers.Where(p=>p.CityId==_cityCode);

        }

        private void CustomerGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(CustomerIdTextBox.Text);

            int kollId = id / 1000000;
            int moinId = id / 1000;
            var newCustomer = new Customer
            {
                CustomerId = id,
                CustomerName = CustomerNameTextBox.Text,
                IsHagigi = IsHagigiRadio.IsChecked ?? false,
                Address = AddressTextBox.Text,
                Noehmalekiyat = OwnershipTypeTextBox.Text,
                Tablo = TabloTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                //CityId = _cityCode, 
                KollId = kollId,
                MoinId = moinId,
                Landlinephone = landingPhoneNumberTextBox.Text,
              //  City = cityripository.GetById(_cityCode),
                CityId = _cityCode,
                

            };

            _ripo.Add(newCustomer);
            var customers = _ripo.GetAll();
            CustomerGrid.ItemsSource = customers.Where(p => p.CityId == _cityCode);
            ClearForm();
        }

        private void ClearForm()
        {
            CustomerIdTextBox.Clear();
            CustomerNameTextBox.Clear();
            AddressTextBox.Clear();
            OwnershipTypeTextBox.Clear();
            TabloTextBox.Clear();
            landingPhoneNumberTextBox.Clear();
            PhoneNumberTextBox.Clear();
            IsHagigiRadio.IsChecked = false;
        }
    }
    }

