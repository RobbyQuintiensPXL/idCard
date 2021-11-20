using BethanysPieShopStockApp.Services;
using idCardXF.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.ViewModels
{
    public class CoursesViewViewModel : BaseViewModel
    {
        private readonly IStudentService _studentService;
        private readonly INavigationService _navigationService;


        public CoursesViewViewModel(IStudentService studentService, INavigationService navigationService)
        {
            _studentService = studentService;
            _navigationService = navigationService;
        }


    }
}
