using idCardXF.Models;
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
    public class PEDateRepository : IPEDateRepository
    {
        private readonly HttpClient _httpClient;
        private const string mainUrl = "https://10.0.2.2:5001";

        public PEDateRepository()
        {
            _httpClient = new HttpClient(DependencyService.Get<IHttpClientHandlerService>().GetInsecureHandler());
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<PEDate>> GetAllPEs(int courseId)
        {
            var url = new Uri($"{mainUrl}/api/pedates/{courseId}");

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<PEDate>>(content);
            }
            return null;
        }
    }
}
