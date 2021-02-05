using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_ASL02_ON_14_12_2020
{
    public class Pyramid:Introduction
    {
        public Pyramid(int row)
        {
            ProTitle();
            Intro("find cube of a number");
            int i, j;
            for (i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
}
