using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.Models
{
    public class Student
    {
        private int _id;
        private string _firstname;
        private string _name;
        private string _email;

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }
        [JsonProperty("firstname")]
        public string Firstname { get => _firstname; set => _firstname = value; }
        [JsonProperty("name")]
        public string Name { get => _name; set => _name = value; }
        [JsonProperty("email")]
        public string Email { get => _email; set => _email = value; }
    }
}
