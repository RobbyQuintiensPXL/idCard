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
    public partial class StudentPEView : ContentPage
    {
        public StudentPEView()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.StudentPEViewViewModel;
        }

        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                scanResultText.Text = result.Text;
            });
        }
    }
}