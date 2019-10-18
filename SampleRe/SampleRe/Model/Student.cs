using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRe.Model
{
    public class Student
    {
        public string Name { get; set; }
        public string RollNo { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }

        public int CalculatePercentage()
        {
            return Marks * 5 / 100;
        }
    }
}
