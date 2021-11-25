using idCardXF;
using idCardXF.ViewModels;

namespace BethanysPieShopStockApp.Utility
{
    public static class ViewModelLocator
    {
        public static HomeViewViewModel HomeViewViewModel { get; set; } = new HomeViewViewModel(App.StudentService, App.LectorService, App.NavigationService);
        public static CoursesViewViewModel CoursesViewViewModel { get; set; } = new CoursesViewViewModel(App.CourseService, App.NavigationService);
        public static LectorViewViewModel LectorViewViewModel { get; set; } = new LectorViewViewModel(App.PEDateService, App.NavigationService);
        public static PEDatesViewViewModel PEDatesViewViewModel { get; set; } = new PEDatesViewViewModel(App.PEDateService, App.NavigationService);
        public static StudentPEViewViewModel StudentPEViewViewModel { get; set; } = new StudentPEViewViewModel(App.StudentPEService, App.NavigationService);
    }
}
