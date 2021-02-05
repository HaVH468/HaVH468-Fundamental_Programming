using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int x;
            Console.Write("Enter the number: ");
            x = Convert.ToInt32(Console.Read());
            if (x < 0)
            {
                Console.WriteLine("The number is not positive");
            }
            else if(x % 3 == 0)
            {
                Console.WriteLine("the number is a multiple of 3");
            }else if(x % 7 == 0)
            {
                Console.WriteLine("the number is a multiple of 7");
            }

            //2
            int y;
            Console.Write("Enter the 1st number: ");
            x = Convert.ToInt32(Console.Read());
            Console.Write("Enter the 2nd number: ");
            y = Convert.ToInt32(Console.Read());
            if (x > -10 && x < 10 || y > -10 && y < 10)
            {
                Console.WriteLine("An integer (from the two given integers) is in the range -10 to 10");
            }

            //3
            if (x < 100 && y > 200 || x > 200 && y < 100)
            {
                Console.WriteLine("true");
            }

            //4
            double p, a;
            Console.Write("Enter the radius of a circle: ");
            x = Convert.ToInt32(Console.Read());
            Console.WriteLine($"the perimeter {p = 2 * x * 3.14}");
            Console.WriteLine($"the area {a = x * x * 3.14}");

            //5
            double v;
            Console.Write("Enter distance: ");
            x = Convert.ToInt32(Console.Read());
            Console.Write("Enter time: ");
            y = Convert.ToInt32(Console.Read());
            Console.WriteLine($"the speed in kilometers per hour {v = x/y}");

            //6
            Console.Write("Enter the radius of a sphere: ");
            x = Convert.ToInt32(Console.Read());
            Console.WriteLine($"the area {a = 4/3 * 3.14 * x*x*x}");

            //7
            bool result = true;
            Console.Write("Enter the 1st number: ");
            x = Convert.ToInt32(Console.Read());
            Console.Write("Enter the 2nd number: ");
            y = Convert.ToInt32(Console.Read());
            if (x % 2 == 0 && y % 2 == 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result = false);
            }
        }
    }
}
