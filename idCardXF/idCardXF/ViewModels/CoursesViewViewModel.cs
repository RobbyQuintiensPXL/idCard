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
    public class CoursesViewViewModel : BaseViewModel
    {
        private Student _student;
        private ObservableCollection<StudentCourse> _courses;


        private readonly ICourseService _courseService;
        private readonly INavigationService _navigationService;


        public CoursesViewViewModel(ICourseService courseService, INavigationService navigationService)
        {
            _courseService = courseService;
            _navigationService = navigationService;

            CourseSelectedCommand = new Command<StudentCourse>(OnCourseSelectedCommand);
        }

        public ICommand CourseSelectedCommand { get; }

        private void OnCourseSelectedCommand(StudentCourse selectedCourse)
        {
            _navigationService.NavigateTo("PEDatesView", selectedCourse);
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

        public ObservableCollection<StudentCourse> Courses
        {
            get => _courses;
            set
            {
                _courses = value;   
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync(object parameter)
        {
            SelectedStudent = parameter as Student;
            Courses = new ObservableCollection<StudentCourse>(await _courseService.GetCourses(_student.Email));
        }
    }
}
