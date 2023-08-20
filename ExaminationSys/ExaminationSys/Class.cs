

using System.Collections.Generic;

namespace ExaminationSys
{
    public class Class
    {
        public string Name { get; set; } = string.Empty;
        public IList<Student> Students { get; set; } = new List<Student>();
        public IList<Professor> Professors { get; set; } = new List<Professor>();
        public IList<Course> Courses { get; set; } = new List<Course>();
    }
}
