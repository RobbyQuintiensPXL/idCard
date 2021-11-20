using BethanysPieShopStockApp.Services;
using idCardXF.Models;
using idCardXF.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.ViewModels
{
    public class CoursesViewViewModel : BaseViewModel
    {
        private Student _student;

        private readonly IStudentService _studentService;
        private readonly INavigationService _navigationService;


        public CoursesViewViewModel(IStudentService studentService, INavigationService navigationService)
        {
            _studentService = studentService;
            _navigationService = navigationService;
        }

        public Student SelectedStudent
        {
            get => _student;
            set
            {
                _student = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }


        public override void Initialize(object parameter)
        {
            SelectedStudent = parameter as Student;
        }



    }
}
