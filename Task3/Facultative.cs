using System.Collections.Generic;

namespace Task3
{
    // This is temporary implementation
    // forgive me for this code

    public class Facultative
    {
        public string Name { get; set; }
        public Teacher HostTeacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public Dictionary<Student, int> grades { get; set; } = new Dictionary<Student, int>();

        public Facultative(string name, Teacher hostTeacher)
        {
            Name = name;
            HostTeacher = hostTeacher;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void Mark(Student student, int grade)
        {
            if (grades.ContainsKey(student))
                grades[student] = grade;
        }

        public void SaveToArchive(Archive archive)
        {
            archive.AddFacultative(this);
        }

    }
}