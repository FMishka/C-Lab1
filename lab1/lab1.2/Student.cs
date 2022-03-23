using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupNumber { get; set; }

        public void Add(Student s)
        {
            Id += s.Id;
            Name += s.Name;
            Age += s.Age;
            GroupNumber += s.GroupNumber;
        }
        public void AddThree(Student s1, Student s2)
        {
            Id += s1.Id;
            Name += s1.Name;
            Age += s1.Age;
            GroupNumber += s1.GroupNumber;

            Id += s2.Id;
            Name += s2.Name;
            Age += s2.Age;
            GroupNumber += s2.GroupNumber;
        }
    }
}
