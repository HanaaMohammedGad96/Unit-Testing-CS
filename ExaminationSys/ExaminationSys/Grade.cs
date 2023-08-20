

namespace ExaminationSys
{
    public class Grade
    {
        public int GradeId { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public double Score { get; set; }
        public string LetterGrade
        {
            get
            {
                if (Score >= 90)
                    return "A";
                else if (Score >= 80)
                    return "B";
                else if (Score >= 70)
                    return "C";
                else if (Score >= 60)
                    return "D";
                else
                    return "F";
            }
        }
    }
}
