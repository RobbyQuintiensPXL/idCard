using BethanysPieShopStockApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace idCardXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LectorView : ContentPage
    {
        public LectorView()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.LectorViewViewModel;
        }
    }
}