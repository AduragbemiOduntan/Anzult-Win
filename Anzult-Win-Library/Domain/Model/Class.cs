using Anzult_Win_Library.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anzult_Win_Library.Domain.Model
{
    public class Class
    {
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public ClassSection Section { get; set; }
        public string ClassFlavours { get; set; }
        public string TeacherID { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Subject> Subject { get; set; }
        public ICollection<Student> Student { get; set; }
       
    }
}
