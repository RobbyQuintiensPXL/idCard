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
    public class LectorRepository : ILectorRepository
    {
        private readonly HttpClient _httpClient;
        private const string mainUrl = "https://10.0.2.2:5001";

        public LectorRepository()
        {
            _httpClient = new HttpClient(DependencyService.Get<IHttpClientHandlerService>().GetInsecureHandler());
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<Lector> GetLector(string email)
        {
            var url = new Uri($"{mainUrl}/api/lectors/{email}");

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Lector>(content);
            }
            return null;
        }
    }
}
