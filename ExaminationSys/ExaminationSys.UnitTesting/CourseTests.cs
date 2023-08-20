using System.Xml.Linq;

namespace ExaminationSys.UnitTesting
{
    [TestFixture]
    public class Tests
    {
        private Course _course;
        [SetUp]
        public void Setup()
        {
            _course = new Course(1, "Physics");
            _course.AddProfessor(new Professor(1, "Hanaa"));

            _course.AddStudent(new Student (1, "Zeyad"));

            _course.AddStudent(new Student (1, "Safaa"));

            _course.AddStudent(new Student (1, "Wafaa"));

            _course.AddStudent(new Student (1, "Esraa"));
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}