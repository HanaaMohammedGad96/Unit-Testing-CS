using System.Collections.Generic;
using System.Linq;

namespace ExaminationSys
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Dictionary<Course, Grade> Grades { get; set; } = new Dictionary<Course, Grade>();

        public Student(int id, string name)
        {
            Id   = id;
            Name = name;
        }

        public Course GetTopCourse()
        {
            if (Grades.Count == 0)
                return null;

            var topCourse = Grades.OrderByDescending(g => g.Value.Score).FirstOrDefault().Key;

            if (topCourse == null) return null;

            return topCourse;
        }

        public double GetTotalScore() => Grades.Sum(g => g.Value.Score);

    }
}
