﻿using DataAcssesLayer.Repositoryes;
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
    /// Interaction logic for TarkhisKar_Irani_UserController.xaml
    /// </summary>
    public partial class TarkhisKar_Irani_UserController : UserControl
    {
        private ITarkhisKarRepository _ripo;
        public TarkhisKar_Irani_UserController(ITarkhisKarRepository ripo)
        {
            InitializeComponent();
            _ripo = ripo;
            TarkhisKarDataGrid.ItemsSource = _ripo.GetIrani();
        }


        private void Button_Add(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(TarkhisKarId.Text);

            int kollId = id / 1000000;
            int moinId = id / 1000;

            var newtarkhisKae = new TarkhisKar
            {
                Id = id,
                KollId = kollId,
                MoinId = moinId,
                TarkisKarHazine = TarkhisKarHazine.Text,
                TarkisKarMojavez = TarkhisKarMojavez.Text,
                TarkisKarName = TarkhisKarName.Text,
                IsIraqi = false,
                
            };

            _ripo.Add(newtarkhisKae);

            TarkhisKarDataGrid.ItemsSource = _ripo.GetIrani();


        }
    }
}
