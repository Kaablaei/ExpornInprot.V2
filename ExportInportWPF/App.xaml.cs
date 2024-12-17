using DataAcssesLayer;
using DataAcssesLayer.Repositoryes;
using DataAcssesLayer.Repositoryes.InterFases;
using ExportInportWPF.Menu.hesabdari;
using ExportInportWPF.Menu.Tarif;
using ExportInportWPF.Menu.Tarif.Accouncoding;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Input;

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
            base.OnStartup(e);

            EventManager.RegisterClassHandler(typeof(UIElement), UIElement.PreviewKeyDownEvent, new KeyEventHandler(HandleEnterAsTab));

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
       
        }

        private void HandleEnterAsTab(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
          
                var element = e.OriginalSource as UIElement;

                if (element != null)
                {
                  
                    element.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                    e.Handled = true; 
                }
            }
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // ثبت Repository ها
            services.AddSingleton<AppDbcontext>();
            services.AddScoped<ICodingKollRepository, CodeKollRepository>();
            services.AddScoped<ICodingGrohTafsiriRepository, CodingGrohTafsiriRepository>();
            services.AddScoped<ICodingMoinRepository, CodingMoinRepository>();
            services.AddScoped<ICoingTafsiliRepository, CoingTafsiliRepository>();
            services.AddScoped<IkalaRepository, kalaRepository>();
            services.AddScoped<IDriversRepository, DriversRepository>();
            services.AddScoped<ITarkhisKarRepository, TarkhisKarRepository>();
    
            services.AddScoped<ISarfkhaneRipository, SarfkhaneRipository>();
            services.AddScoped<IFarmerRipository, FarmerRipository>();
            services.AddScoped<IBorderRepository, BorderRepository>();
            services.AddScoped<ICityripository, CityRipository>();

            // ثبت View ها
            services.AddScoped<MainWindow>();
            services.AddScoped<Koll_Coding_Tarif_UserControl>();
            services.AddScoped<GrohTafsili_Tarif_UserControl>();
            services.AddScoped<Moin_coding_Tarif_UserControler>();
            services.AddScoped<Tafsili_Coding_Tarif_UserController>();
            services.AddScoped<Kala_Tarif_userControll>();
            services.AddScoped<Irani_Driver_Mun_UserContoller>();
            services.AddScoped<IraQi_Drivers_menu_UserConteolles>();
            services.AddScoped<TarkhisKar_Irani_UserController>();
            services.AddScoped<Tarkhis_Iraqi_UserController>();
            services.AddScoped<AsnadeHeabdari_UserContoller>();
            services.AddScoped<Marz_tarif_userContoller>();
            services.AddScoped<Sardkhane_Tarif_Menu>();
            services.AddScoped<Farmers_Menu>();
            services.AddScoped<City_menu_UserController>();
       
        }
    }
}


