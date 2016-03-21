using System.Collections.Generic;

namespace Task3
{
    public class Archive
    {
        public List<Facultative> facultatives { get; set; } = new List<Facultative>();

        public void AddFacultative(Facultative f)
        {
            facultatives.Add(f);
        }
    }
}