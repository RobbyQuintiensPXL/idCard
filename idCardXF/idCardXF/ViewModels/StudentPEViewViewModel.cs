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
        public string _studentEmail;

        private readonly IStudentPEService _studentPEService;
        private readonly INavigationService _navigationService;

        public StudentPEViewViewModel(IStudentPEService studentPEService, INavigationService navigationService)
        {
            _studentPEService = studentPEService;
            _navigationService = navigationService;

            SelectedPE = new PEDate();
            SendButton = new Command(OnSendButtonClicked);
        }

        //public bool EmailScanned(object obj) => 
        //    !String.IsNullOrEmpty(_studentEmail);


        public ICommand SendButton { get; }

        public string ScannedEmail
        {
            get => _studentEmail;
            set
            {
                _studentEmail = value;
                OnPropertyChanged();
            }
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



        public async void OnSendButtonClicked()
        {
            if (!String.IsNullOrEmpty(_studentEmail))
            {
                StudentPE studentPE = await _studentPEService.GetStudentByIdAndEmail(SelectedPE.Id, _studentEmail);
                studentPE.Attented = true;
                await _studentPEService.ScanStudent(SelectedPE.Id, _studentEmail, studentPE);
                ScannedEmail = null;
            }
        }

        public override async Task InitializeAsync(object parameter)
        {
            SelectedPE = parameter as PEDate;
            StudentsPE = new ObservableCollection<StudentPE>(await _studentPEService.GetStudents(_pEDate.Id));
        }
    }
}
