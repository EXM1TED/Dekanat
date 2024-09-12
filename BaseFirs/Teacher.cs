using System;
using System.Collections.Generic;

namespace BaseFirs;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int DisciplineId { get; set; }

    public virtual Discipline Discipline { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
