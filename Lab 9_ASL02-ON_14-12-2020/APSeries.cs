using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_ASL02_ON_14_12_2020
{
    class APSeries:Introduction
    {
        private int n1;
        private int df;
        private int n2;
        ~APSeries()
        {
            ProTitle();
            Intro("find cube of a number");
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
