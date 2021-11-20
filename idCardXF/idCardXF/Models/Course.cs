using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.Models
{
    public class Course
    {
        private int _id;
        private string _name;
        private Lector _lector;

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("name")]
        public string Name { get => _name; set => _name = value; }

        [JsonProperty("lector")]
        public Lector Lector { get => _lector; set => _lector = value; }

    }
}
