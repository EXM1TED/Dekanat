using System;
using System.Collections.Generic;

namespace BaseFirs;

public partial class Course
{
    public int CourseId { get; set; }

    public string NameOfCourse { get; set; } = null!;

    public int TeacherId { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
