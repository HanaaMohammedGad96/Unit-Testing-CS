

using System.Collections.Generic;
using System.Linq;

namespace ExaminationSys
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        private IList<Professor> Professors{ get; set; }
        private IList<Student> EnrolledStudents { get; set; } = new List<Student>();

        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Student GetTopStudent ()
        {
            if (EnrolledStudents.Count == 0)
                return null;
            var topStudent = EnrolledStudents.OrderByDescending(s => s.Grades.ContainsKey(this) ? s.Grades[this].Score : 0)
                .FirstOrDefault();
            if (topStudent == null) return null;
            return topStudent;  
        }

        public void AddProfessor(Professor professor) => Professors.Add(professor);

        public void AddStudent(Student student) => EnrolledStudents.Add(student);
    }
}
