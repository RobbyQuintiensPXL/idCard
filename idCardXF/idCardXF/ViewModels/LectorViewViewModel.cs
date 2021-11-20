using BethanysPieShopStockApp.Services;
using idCardXF.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.ViewModels
{
    public class LectorViewViewModel : BaseViewModel
    {
        private readonly ILectorService _lectorService;
        private readonly INavigationService _navigationService;

        public LectorViewViewModel(ILectorService lectorService, INavigationService navigationService)
        {
            _lectorService = lectorService;
            _navigationService = navigationService;
        }
    }
}
