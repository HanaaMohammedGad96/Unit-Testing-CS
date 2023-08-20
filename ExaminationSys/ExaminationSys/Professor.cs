

using System.Collections.Generic;

namespace ExaminationSys
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Professor(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
