using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApp.API.Models
{
    public class Lector
    {
        private int _id;
        private string _firstname;
        private string _name;
        private string _email;
        private Role _role;
        private Course course;
        private int _courseId;
        

        public int Id { get => _id; set => _id = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Name { get => _name; set => _name = value; }
        public Role Role { get => _role; set => _role = value; }
        public string Email { get => _email; set => _email = value; }

        [JsonIgnore]
        public virtual Course Course { get => course; set => course = value; }
        public int CourseId { get => _courseId; set => _courseId = value; }
    }
}
