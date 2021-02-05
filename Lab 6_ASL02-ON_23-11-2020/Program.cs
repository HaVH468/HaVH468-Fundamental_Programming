using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_ASL02_ON_23_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Student std = new Student("a123","Jonny Tiller",5,4,3);
            std.TotalMark = std.Math + std.Physic + std.English;
            std.FinalGrade = std.TotalMark / 3;
            std.Infor();
          
        }
    }
}
