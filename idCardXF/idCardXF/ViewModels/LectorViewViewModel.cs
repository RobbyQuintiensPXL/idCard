using BethanysPieShopStockApp.Services;
using idCardXF.Models;
using idCardXF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace idCardXF.ViewModels
{
    public class LectorViewViewModel : BaseViewModel
    {
        private Lector _lector;
        private ObservableCollection<PEDate> _pEDates;

        private readonly IPEDateService _pEDateService;
        private readonly INavigationService _navigationService;

        public LectorViewViewModel(IPEDateService pEDateService, INavigationService navigationService)
        {
            _pEDateService = pEDateService;
            _navigationService = navigationService;

            PESelectedCommand = new Command<PEDate>(OnPESelectedCommand);
        }

        public ICommand PESelectedCommand { get; }

        private void OnPESelectedCommand(PEDate selectedPE)
        {
            _navigationService.NavigateTo("StudentPEView", selectedPE);
        }

        public Lector SelectedCourse
        {
            get => _lector;
            set
            {
                _lector = value;
                OnPropertyChanged(nameof(SelectedCourse));
            }
        }

        public ObservableCollection<PEDate> PEDates
        {
            get => _pEDates;
            set
            {
                _pEDates = value;
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync(object parameter)
        {
            SelectedCourse = parameter as Lector;
            PEDates = new ObservableCollection<PEDate>(await _pEDateService.GetAllPEs(_lector.CourseId));
        }
    }
}
