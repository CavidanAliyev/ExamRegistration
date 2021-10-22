using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Represents an student
    /// </summary>
    public class Student : BaseEntity
    {
        /// <summary>
        /// Gets and sets student number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets and sets first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets and sets last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets and sets class number
        /// </summary>
        public int Class { get; set; }
    }
}
