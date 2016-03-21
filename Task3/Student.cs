using System.Collections.Generic;

namespace Task3
{
    public class Student : Person
    {
        private List<Facultative> facultatives;

        public Student(string name)
        {
            Name = name;
        }

        public void Subcribe(Facultative facultative)
        {
            facultative.AddStudent(this);
        }

    }
}