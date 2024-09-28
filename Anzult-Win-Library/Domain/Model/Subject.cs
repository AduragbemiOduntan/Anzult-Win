using Anzult_Win_Library.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anzult_Win_Library.Domain.Model
{
    public class Subject
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public SubjectClassCode SubjectClassCode { get; set; }
        public string MyProperty { get; set; }
        public ICollection<Result> Result { get; set; }
    } 
}
