using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_ASL02_ON_14_12_2020
{
    public class Floyd_sTriangle:Introduction
    {
        ~Floyd_sTriangle()
        {
            ProTitle();
            Intro("find cube of a number");
            int row, x = 1;
            Console.WriteLine("Enter the number of rows:");
            row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{x} ");
                    x++;
                }

                Console.WriteLine();
            }
        }
    }
}
