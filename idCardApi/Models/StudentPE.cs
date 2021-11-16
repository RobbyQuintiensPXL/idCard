using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Models
{
    public class StudentPE
    {
        private string _studentEmail;
        private int _peId;
        private Student _student;
        private PEDate _peDate;
        private bool _attented;

        public string StudentEmail { get => _studentEmail; set => _studentEmail = value; }
        public int PeId { get => _peId; set => _peId = value; }
        public Student Student { get => _student; set => _student = value; }
        public PEDate PeDate { get => _peDate; set => _peDate = value; }
        public bool Attented { get => _attented; set => _attented = value; }
    }
}
