using System;
using System.Collections.Generic;

namespace BaseFirs;

public partial class Discipline
{
    public int DisciplineId { get; set; }

    public string DisciplineName { get; set; } = null!;

    public int CountOfHours { get; set; }
}
