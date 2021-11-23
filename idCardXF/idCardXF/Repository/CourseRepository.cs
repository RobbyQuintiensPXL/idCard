using idCardXF.Models;
using idCardXF.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace idCardXF.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly HttpClient _httpClient;
        private const string mainUrl = "https://10.0.2.2:5001";

        public CourseRepository()
        {
            _httpClient = new HttpClient(DependencyService.Get<IHttpClientHandlerService>().GetInsecureHandler());
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<StudentCourse>> GetAllCourses(string email)
        {
            var url = new Uri($"{mainUrl}/api/studentcourses/{email}");

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<StudentCourse>>(content);
            }
            return null;
        }
    }
}
