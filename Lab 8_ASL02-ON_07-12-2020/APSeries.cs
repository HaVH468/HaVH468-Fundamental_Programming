using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_ASL02_ON_07_12_2020
{
    public class APSeries
    {
 
        private int n1;
        private int df;
        private int n2;

        ~APSeries()
        {
            Console.WriteLine("Enter  the starting number of the A.P. series: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  the number of items of the A.P. series: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  the common different of the A.P. series: ");
            df = Convert.ToInt32(Console.ReadLine());
            int s1 = (n2 * (2 * n1 + (n2 - 1) * df)) / 2;
            Console.WriteLine("The Sum of the  A.P. series are : ", s1);
        }
    }
}
