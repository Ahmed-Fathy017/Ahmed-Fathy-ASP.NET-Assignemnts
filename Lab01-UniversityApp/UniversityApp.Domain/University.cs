using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityApp.Domain
{
    public class University
    {
        public University()
        {
            Students = new List<Student>();
        }
        public int Id { set; get; }
        public string Name { set; get; }
        public List<Student> Students { get; set; }
    }
}
