﻿using DataAcssesLayer;
using DataAcssesLayer.Repositoryes;
using DataAcssesLayer.Repositoryes.InterFases;
using ExportInportWPF.Menu.Tarif.Accouncoding;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ExportInportWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
       
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // ثبت Repository ها
            services.AddSingleton<AppDbcontext>();
            services.AddScoped<ICodingKollRepository, CodeKollRepository>();
            services.AddScoped<ICodingGrohTafsiriRepository, CodingGrohTafsiriRepository>();
            services.AddScoped<ICodingMoinRepository, CodingMoinRepository>();

            // ثبت View ها
            services.AddScoped<MainWindow>();
            services.AddScoped<Koll_Coding_Tarif_UserControl>();
            services.AddScoped<Moin_coding_Tarif_UserControler>();
        }
    }
}


