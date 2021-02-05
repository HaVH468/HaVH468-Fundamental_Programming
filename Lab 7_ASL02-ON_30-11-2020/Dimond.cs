using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_ASL02_ON_30_11_2020
{
    public class Dimond
    {
        public int Row { get; set; }

        public Dimond(int row)
        {
            int i, j;
            for (i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = row - 1; i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
    
}
