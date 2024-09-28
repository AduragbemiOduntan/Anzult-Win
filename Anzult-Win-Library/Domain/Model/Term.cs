using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anzult_Win_Library.Domain.Model
{
    public class Term
    {
        public int TermID { get; set; } 
        public string TermName { get; set; } 
        public string AcademicYearID { get; set; } 
        public AcademicYear AcademicYear { get; set; } 
        public ICollection<Result> Results { get; set; }
    }
}
