using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_ASL02_ON_07_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            OddNumber o = new OddNumber(5);
            Console.WriteLine(o.Sum);
            Pyramid p = new Pyramid(8);
            APSeries ap = new APSeries();
            Floyd_sTriangle floy = new Floyd_sTriangle();
            Console.ReadKey();
        }
    }
}
