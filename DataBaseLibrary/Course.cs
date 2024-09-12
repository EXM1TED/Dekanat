using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps.Serialization;

namespace DataBaseLibrary
{
    public class Course
    {
        public Course(string nameOfCourse, int teacherId)
        {
            this.NameOfCourse = nameOfCourse;
            this.TeacherId = teacherId;
        }

        public int CourseId { get; set; }

        public string NameOfCourse { get; set; } = null!;

        public int TeacherId { get; set; }
        Teacher? Teacher { get; set; }
        List<Group> CourseList { get; set; } = new List<Group>();
    }
}
