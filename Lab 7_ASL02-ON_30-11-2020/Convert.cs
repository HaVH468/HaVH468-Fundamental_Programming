using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_ASL02_ON_30_11_2020
{
    public class Convert
    {
        public int bin { get; set; }
      
        public Convert(int dec)
        {
            int i = 1;
            while (dec>0)
            {
                this.bin = this.bin + (dec % 2) * i;
                i = i * 10;
                dec = dec / 2;
            }
        }
    }
}
