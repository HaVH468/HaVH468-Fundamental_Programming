using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_ASL02_ON_30_11_2020
{
    public class Reverser
    {
        public int Number { get; set; }
        public Reverser(int number)
        {
            int reverse = 0, i;
            while (number != 0)
            {
                i = number % 10;
                reverse = reverse * 10 + i;
                number /= 10;
            }
            this.Number = number;
        }
    }
}
