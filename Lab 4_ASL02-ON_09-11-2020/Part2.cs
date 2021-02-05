using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_ASL02_ON_09_11_2020
{
    class Part2
    {
        //1
        public static int SpaceCount(string str)
        {
            int count = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    count++;
            }
            return count;
        }

        //2
        public static void Swap2Num(int x, int y)
        {
            int tmp;
            tmp = x;
            x = y;
            y = tmp;
            Console.WriteLine($"1st number = {x}, 2nd number = {y}");
        }

        //3
        public static string CheckPrime(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return "The number is not prime number";
                }
            }
            return "The number is prime number";
        }

        //4
        public static int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        //5
        public static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
