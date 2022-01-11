using P224Exception.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P224Exception.Models
{
    class Group
    {
        public string Name { get; set; }
        public List<Students> StudentsList { get; set; }
        public Group()
        {
            StudentsList = new List<Students>();
        }

        public Students FindStudent(string name)
        {
            Students students = StudentsList.Find(s => s.Name == name);
            if (students == null)
            {
                Console.WriteLine( new DontFindStudent("Telebe Tapilmadi").message);

            }
            return students;
        }
    }
}
