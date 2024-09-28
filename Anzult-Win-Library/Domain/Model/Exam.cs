using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anzult_Win_Library.Domain.Model
{
    public class Exam
    {
        //Should there be an academic year here?
        public string ExamID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Term { get; set; }
        public DateTime ExamDate { get; set; }
        public string ClassID { get; set; } 
        public Class Class { get; set; } 
        public ICollection<Result> Results { get; set; }
    }
}
