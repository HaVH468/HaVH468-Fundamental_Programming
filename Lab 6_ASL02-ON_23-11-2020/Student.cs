using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_ASL02_ON_23_11_2020
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public float Math { get; set; }
        public float Physic { get; set; }
        public float English { get; set; }
        public float TotalMark { get; set; }
        public float FinalGrade { get; set; }

        public Student(string id, string name, float math, float physic, float english)
        {
            this.StudentID = id;
            this.Name = name;
            this.Math = math;
            this.Physic = physic;
            this.English = english;
        }

        public string Infor()
        {
            return $"Name: {this.Name}, studentID: {this.StudentID}, final grade: {FinalGrade}";
        }
    }
}
