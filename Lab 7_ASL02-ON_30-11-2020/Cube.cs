using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_ASL02_ON_30_11_2020
{
    public class Cube
    {
        private int cube;
        private int num;

        public Cube(int n)
        {
            this.num = n;
            this.cube = n * n * n;
        }
    }
}
