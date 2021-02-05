using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_ASL02_ON_07_12_2020
{
    public class OddNumber
    { 
        public int Sum { get; set; }
        public OddNumber(int term)
        {
            for (int i = 1; i <= term; i++)
            {
                this.Sum += 2 * i - 1;
            }
        }
    }
}
