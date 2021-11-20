using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Utility;
using idCardXF.Repository;
using idCardXF.Services;
using idCardXF.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Lobster-Regular.ttf", Alias = "Lobster")]

namespace idCardXF
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; } = new NavigationService();
        public static IStudentService StudentService { get; set; } = new StudentService(new StudentRepository());
        public App()
        {
            InitializeComponent();

            NavigationService.Configure(ViewNames.HomeView, typeof(HomeView));
            NavigationService.Configure(ViewNames.CoursesView, typeof(CoursesView));

            MainPage = new NavigationPage(new HomeView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
