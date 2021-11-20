using idCardXF;
using idCardXF.ViewModels;

namespace BethanysPieShopStockApp.Utility
{
    public static class ViewModelLocator
    {
        public static HomeViewViewModel HomeViewViewModel { get; set; } = new HomeViewViewModel(App.StudentService, App.NavigationService);
        public static CoursesViewViewModel CoursesViewViewModel { get; set; } = new CoursesViewViewModel(App.StudentService, App.NavigationService);
    }
}
