using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.Models
{
    public class StudentCourse
    {
        private string _studentEmail;
        private int _courseId;
        private Course course;

        [JsonProperty("studentMail")]
        public string StudentEmail { get => _studentEmail; set => _studentEmail = value; }

        [JsonProperty("courseId")]
        public int CourseId { get => _courseId; set => _courseId = value; }

        [JsonProperty("course")]
        public Course Course { get => course; set => course = value; }
    }
}
