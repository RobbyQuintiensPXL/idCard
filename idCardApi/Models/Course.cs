using idCardApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApp.API.Models
{
    public class Course
    {
        private int _id;
        private string _name;
        private Lector _lector;
        private ICollection<StudentCourse> _students;
        private ICollection<PEDate> _peDates;


        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public Lector Lector { get => _lector; set => _lector = value; }

        public virtual ICollection<StudentCourse> Students { get => _students; set => _students = value; }

        public virtual ICollection<PEDate> PeDates { get => _peDates; set => _peDates = value; }
    }
}
