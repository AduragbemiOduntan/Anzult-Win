using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anzult_Win_Library.Domain.Model
{
    public class Teacher
    {
        public string TeacherID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public ICollection<Class> Class { get; set; }
    }
}
