using System;
using System.Collections.Generic;

namespace BaseFirs;

public partial class Group
{
    public int GroupId { get; set; }

    public string NameOfGroup { get; set; } = null!;

    public int CountOfStudents { get; set; }

    public int TeacherId { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
