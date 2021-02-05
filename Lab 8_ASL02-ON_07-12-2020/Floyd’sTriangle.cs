using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_ASL02_ON_07_12_2020
{
    public class Floyd_sTriangle
    {
        ~Floyd_sTriangle()
        {
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
