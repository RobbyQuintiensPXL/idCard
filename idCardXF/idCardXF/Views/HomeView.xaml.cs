
using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace idCardXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.HomeViewViewModel;
        }
    }
}