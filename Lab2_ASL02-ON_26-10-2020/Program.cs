using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int x, y, result;
            Console.Write("Enter the first number: ");
            x = Convert.ToInt32(Console.Read());
            Console.Write("Enter the second number: ");
            y = Convert.ToInt32(Console.Read());
            Console.WriteLine($"Sum = {result = x + y}");
            Console.WriteLine($"Subtract = {result = x - y}");
            Console.WriteLine($"Multiple = {result = x * y}");
            Console.WriteLine($"Divide = {result = x / y}");

            //2
            Console.Write("Enter the number: ");
            x = Convert.ToInt32(Console.Read());
            Console.WriteLine($"Multiplication table of {x} ");
            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(result = x * i);
            }

            //3
            bool re;
            Console.Write("Enter the first number: ");
            x = Convert.ToInt32(Console.Read());
            Console.Write("Enter the second number: ");
            y = Convert.ToInt32(Console.Read());
            if (x < 0 && y > 0 || x > 0 && y < 0)
            {
                Console.WriteLine(re = true);
            }
            else
            {
                Console.WriteLine(re = false);
            }

            //4
            Console.Write("Enter the number: ");
            x = Convert.ToInt32(Console.Read());
            if(20 <= x && x <= 100)
            {
                Console.WriteLine("The given integer is within 20 of 100");
            }
            else
            {
                Console.WriteLine("The given integer is not within 20 of 100");
            }

            //5
            for (int i = 1; i <= 99; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
