using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anzult_Win_Library.Domain.Model
{
    public class Result
    {
        public string ResultID { get; set; }
        public string StudentID { get; set; } 
        public string ExamID { get; set; } 
        public string SubjectID { get; set; } 
        public string TermID { get; set; } 
        public decimal Score { get; set; }
        public Student Student { get; set; } 
        public Exam Exam { get; set; } 
        public Subject Subject { get; set; } 
        public Term Term { get; set; }
    }
}
