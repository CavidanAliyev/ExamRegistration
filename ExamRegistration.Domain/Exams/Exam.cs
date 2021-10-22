using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Represents an exam
    /// </summary>
    public class Exam : BaseEntity
    {
        /// <summary>
        /// Gets or sets the lesson code
        /// </summary>
        public string LessonCode { get; set; }

        /// <summary>
        /// Gets or sets the student number
        /// </summary>
        public int StudentNumber { get; set; }

        /// <summary>
        /// Gets or sets the exam date
        /// </summary>
        public DateTime ExamDate { get; set; }

        /// <summary>
        /// Gets or sets the student grade in the exam
        /// </summary>
        public string Grade { get; set; } 
    }
}
