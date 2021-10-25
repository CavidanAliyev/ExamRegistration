using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Domain.Lessons
{
    /// <summary>
    /// Represents an lesson
    /// </summary>
    public class Lesson : BaseEntity
    {
        /// <summary>
        /// Gets or sets the lesson code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the lesson name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the class number
        /// </summary>
        public int Class { get; set; }

        /// <summary>
        /// Gets or sets the teacher firstname
        /// </summary>
        public string TeacherFirstName { get; set; }

        /// <summary>
        /// Gets or sets the teacher lastname
        /// </summary>
        public string TeacherLastName { get; set; }
    }
}
