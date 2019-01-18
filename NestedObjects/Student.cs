using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Student
    {
        //Constructor
        public Student()
        {
            AssignedAdvisor = new Advisor();
        }

        /// <summary>
        /// The full name of the student
        /// (First Middle Initial Last)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The ? makes it so the DateTime can be NULL
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        public Advisor AssignedAdvisor { get; set; }
    }
}
