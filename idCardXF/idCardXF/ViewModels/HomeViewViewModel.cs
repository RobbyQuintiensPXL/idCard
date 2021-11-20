using BethanysPieShopStockApp.Services;
using idCardXF.Models;
using idCardXF.Services;
using idCardXF.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace idCardXF.ViewModels
{
    public class HomeViewViewModel : BaseViewModel
    {
        private readonly IStudentService _studentService;
        private readonly ILectorService _lectorService;
        private readonly INavigationService _navigationService;
        private string emailAddress;

        public HomeViewViewModel(IStudentService studentService, ILectorService lectorService, INavigationService navigationService)
        {
            _studentService = studentService;
            _navigationService = navigationService;
            _lectorService = lectorService;

            ButtonClicked = new Command(OnButtonClicked);
        }

        public ICommand ButtonClicked { get; }

        public string EmailBinding
        {
            get { return emailAddress; }
            set
            {
                emailAddress =  value;
                OnPropertyChanged();
            }
        }

        public async void OnButtonClicked()
        {
            if (emailAddress.Contains("student"))
            {
                Student student = await _studentService.GetStudent(emailAddress);
                if (student != null)
                {
                    _navigationService.NavigateTo("CoursesView", student);
                }
            } else {
                Lector lector = await _lectorService.GetLector(emailAddress);
                if(lector != null)
                {
                    _navigationService.NavigateTo("LectorView");
                }
            }
            
        }
    }
}
