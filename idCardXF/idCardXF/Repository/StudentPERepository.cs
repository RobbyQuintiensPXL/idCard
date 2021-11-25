﻿using idCardXF.Models;
using idCardXF.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace idCardXF.Repository
{
    public class StudentPERepository : IStudentPERepository
    {

        private readonly HttpClient _httpClient;
        private const string mainUrl = "https://10.0.2.2:5001";

        public StudentPERepository()
        {
            _httpClient = new HttpClient(DependencyService.Get<IHttpClientHandlerService>().GetInsecureHandler());
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<StudentPE>> GetAllStudents(int peId)
        {
            var url = new Uri($"{mainUrl}/api/studentpe/pe/{peId}");

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<StudentPE>>(content);
            }
            return null;
        }

        public async Task ScanStudent(StudentPE studentPE, string email)
        {
            var json = JsonConvert.SerializeObject(studentPE);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"{mainUrl}/studentpe/{studentPE.PeId}/{email}", content);
        }
    }
}
