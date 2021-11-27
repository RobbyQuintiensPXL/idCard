using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace idCardXF.Models
{
    public class PEDate
    {
        private int _id;
        private DateTime _date;
        private Type _type;
        private int _courseId;

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("date")]
        public DateTime Date { get => _date; set => _date = value; }

        [JsonProperty("type")]
        public Type Type { get => _type; set => _type = value; }

        [JsonProperty("courseId")]
        public int CourseId { get => _courseId; set => _courseId = value; }

        public static implicit operator PEDate(StudentPE v)
        {
            throw new NotImplementedException();
        }
    }
}
