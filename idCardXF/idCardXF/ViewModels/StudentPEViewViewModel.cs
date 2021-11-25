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
    public class StudentPEViewViewModel : BaseViewModel
    {
        private ObservableCollection<StudentPE> _studentsPE;
        private PEDate _pEDate;
        private string _studentEmail;

        private readonly IStudentPEService _studentPEService;
        private readonly INavigationService _navigationService;

        public StudentPEViewViewModel(IStudentPEService studentPEService, INavigationService navigationService)
        {
            _studentPEService = studentPEService;
            _navigationService = navigationService;

            SelectedPE = new PEDate();

        }

        public PEDate SelectedPE
        {
            get => _pEDate;
            set
            {
                _pEDate = value;
                OnPropertyChanged(nameof(SelectedPE));
            }
        }

        public ObservableCollection<StudentPE> StudentsPE
        {
            get => _studentsPE;
            set
            {
                _studentsPE = value;
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync(object parameter)
        {
            SelectedPE = parameter as PEDate;
            StudentsPE = new ObservableCollection<StudentPE>(await _studentPEService.GetStudents(_pEDate.Id));
        }
    }
}
