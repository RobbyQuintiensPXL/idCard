using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.Models
{
    public class StudentPE
    {
        private string _studentEmail;
        private int _peId;
        private bool _attented;

        [JsonProperty("studentEmail")]
        public string StudentEmail { get => _studentEmail; set => _studentEmail = value; }

        [JsonProperty("peId")]
        public int PeId { get => _peId; set => _peId = value; }

        [JsonProperty("attented")]
        public bool Attented { get => _attented; set => _attented = value; }
    }
}
