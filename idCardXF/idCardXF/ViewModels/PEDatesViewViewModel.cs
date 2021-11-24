using BethanysPieShopStockApp.Services;
using idCardXF.Models;
using idCardXF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.ViewModels
{
    public class PEDatesViewViewModel: BaseViewModel
    {

        private StudentCourse _studentCourse;
        private ObservableCollection<PEDate> _pEDates;


        private readonly IPEDateService _pEDateService;
        private readonly INavigationService _navigationService;

        public PEDatesViewViewModel(IPEDateService pEDateService, INavigationService navigationService)
        {
            _pEDateService = pEDateService;
            _navigationService = navigationService;

            SelectedCourse = new StudentCourse();
        }

        public StudentCourse SelectedCourse
        {
            get => _studentCourse;
            set
            {
                _studentCourse = value;
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
            SelectedCourse = parameter as StudentCourse;
            PEDates = new ObservableCollection<PEDate>(await _pEDateService.GetAllPEs(_studentCourse.CourseId));
        }




    }
}
