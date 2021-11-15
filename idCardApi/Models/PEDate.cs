using idCardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace idCardApp.API.Models
{
    public class PEDate
    {
        private int _id;
        private DateTime _date;
        private Course _course;
        private int _courseId;
        private PEType _type;

        public int Id { get => _id; set => _id = value; }
        public DateTime Date { get => _date; set => _date = value; }

        [JsonIgnore]
        public Course Course { get => _course; set => _course = value; }

        public PEType Type { get => _type; set => _type = value; }
        public int CourseId { get => _courseId; set => _courseId = value; }
    }
}
