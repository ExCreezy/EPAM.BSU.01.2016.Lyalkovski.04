using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    public delegate void Announcing(Facultative facultative);

    public class Teacher : Person
    {
        private List<Facultative> facultatives = new List<Facultative>();

        public event Announcing Announce;

        public void CreateFacultative(string name)
        {
            Facultative newFac = new Facultative(name, this);
            facultatives.Add(newFac);
            Announce?.Invoke(newFac);
        }

        private void MarkStudents(List<int> grades, Facultative facultative)
        {
            if (grades.Count == facultative.Students.Count)
                for (int i = 0; i < facultative.Students.Count; i++)
                {
                    facultative.Mark(facultative.Students[i], grades[i]);
                }
        }

        // temporary!
        public void FinishFacultative(string name, List<int> grades, Archive archive)
        {
            Facultative current = facultatives.Find(f => f.Name == name);

            MarkStudents(grades, current);

            current.SaveToArchive(archive);

            facultatives.Remove(current);
        }

    }
}