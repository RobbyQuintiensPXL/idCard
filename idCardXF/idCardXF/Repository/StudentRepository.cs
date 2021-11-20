using idCardXF.Models;
using idCardXF.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace idCardXF.Repository
{
    class StudentRepository : IStudentRepository
    {
        private readonly HttpClient _httpClient;
        private const string mainUrl = "https://10.0.2.2:5001";
       
        public StudentRepository()
        {
            _httpClient = new HttpClient(DependencyService.Get<IHttpClientHandlerService>().GetInsecureHandler());
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<Student> GetStudent(string email)
        {
            var url = new Uri($"{mainUrl}/api/students/{email}");

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Student>(content);
            }
            return null;
        }
    }
}
