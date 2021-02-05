using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_ASL02_ON_14_12_2020
{
    public class Cube:Introduction
    {
        private int cube;
        private int num;

        public Cube(int n)
        {
            ProTitle();
            Intro("find cube of a number");
            this.num = n;
            this.cube = n * n * n;
        }
    }
}
