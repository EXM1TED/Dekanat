using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps.Serialization;

namespace DataBaseLibrary
{
    public class Teacher
    {
        public Teacher()
        {
            
        }

        public Teacher(string firstName,
            string middleName,
            string lastName,
            int disciplineId,
            Discipline discipline)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.DisciplineId = disciplineId;
            this.Discipline = discipline;
        }

        public int TeacherId { get; set; }

        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public int DisciplineId { get; set; } // Связь один ко многим. Одна дисциплина для множества преподователей
        public Discipline? Discipline { get; set; } 

        List<Group> Groups { get; set; } = new List<Group>();

        List<Course> Courses { get; set; } = new();
    }
}
