using Anzult_Win_Library.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Anzult_Win_Library.Domain.Model
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string ClassID { get; set; }
        public string AdmissionDate { get; set; }
        public string AdmissionNumber { get; set; }
        public string StudentRegNumber { get; set; }
        public StudentSatus Status { get; set; }
        public bool IsActive { get; set; } = true;
        public Class Class { get; set; }
    }
}
