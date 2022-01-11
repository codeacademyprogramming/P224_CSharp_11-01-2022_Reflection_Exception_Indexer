using System;
using System.Collections.Generic;
using System.Text;

namespace P224DemoLibrary.Models
{
    class Developer : Person
    {
        public string Position { get; set; }
        public string Experiance { get; set; }
        private double Salary { get; set; }

        public string Write(string str, int age)
        {
            return $"{Name} {SurName} {Position} {str} {age}";
        }
    }
}
