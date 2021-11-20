using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.Models
{
    class Course
    {
        private int _id;
        private string _name;
        private Lector _lector;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public Lector Lector { get => _lector; set => _lector = value; }
    }
}
