
namespace DataBaseLibrary
{
    public class Discipline
    {

        public Discipline()
        {
           
        }
        public Discipline(string nameOfDiscipline, int countOfHours)
        {
            this.DisciplineName = nameOfDiscipline;
            this.CountOfHours = countOfHours;
        }

        public int DisciplineId { get; set; }

        public string DisciplineName { get; set; }

        public int CountOfHours { get; set; }

        List<Teacher> Teachers { get; set; } = new List<Teacher>();

    }
}
