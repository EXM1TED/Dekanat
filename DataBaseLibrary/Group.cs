using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public class Group
    {
        public Group(string nameOfGroup, int courseId, int countOfStudents)
        {
            this.NameOfGroup = nameOfGroup;
            this.CourseId = courseId;
            this.CountOfStudents = countOfStudents;
        }

        public int GroupId { get; set; }

        public string NameOfGroup { get; set; } = null!;

        public int CountOfStudents { get; set; }

        public int TeacherId { get; set; }
        Teacher? Teacher { get; set; }

        public int CourseId { get; set; }
        Course? Course { get; set; }
    }
}
