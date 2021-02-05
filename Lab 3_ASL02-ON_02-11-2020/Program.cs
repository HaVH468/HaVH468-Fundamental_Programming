using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_ASL02_ON_02_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int x, y, z, max;
            Console.WriteLine("Enter 3 integer number: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y && x > z)
            {
                max = x;
            }
            else if(y > x && y > z)
            {
                max = y;
            }
            else
            {
                max = z;
            }
            Console.WriteLine("Maximum number: ", max);

            //3
            if (x == 0)
            {
                Console.WriteLine("The number is 0");
            }
            else if(x > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }

            //4
            if(x%2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            //5
            char c;
            Console.WriteLine("Enter character: ");
            c = Convert.ToChar(Console.ReadLine());
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                Console.WriteLine(c + "is an Alphabet. ");
            }
            else
            {
                Console.WriteLine(c + "is not an Alphabet. ");
            }

            //6
            Console.WriteLine("Enter the month (from 1 to 12): ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 13; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("28 or 29 days");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("30 days");
                }
                else
                {
                    Console.WriteLine("31 days");
                }
            }

            //1
            Console.Write("Enter number: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (x == i)
                {
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine("Not allowed");

            //2
            Console.Write("Enter the 1st number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fomula (+,-,*,/): ");
            c = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            y = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine(x + y);
                    break;
                case '-':
                    Console.WriteLine(x - y);
                    break;
                case '*':
                    Console.WriteLine(x * y);
                    break;
                case '/':
                    Console.WriteLine(x / y);
                    break;
            }

            //3
            Console.WriteLine("C#  program to convert Binary to Hexadecimal number system");
            Console.Write("Enter binary number (4 digits): ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] arr = {0,0000,1,0001,2,0010,3,0011,4,0100,5,0101,6,0110,7,0111,
                        8,1000,9,1001};
            for(int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i + 1])
                {
                    Console.WriteLine("Hexadecimal number: ", arr[i]);
                }
            }
            switch (x)
            {
                case 1010:
                    Console.WriteLine("Hexadecimal number: A");
                    break;
                case 1011:
                    Console.WriteLine("Hexadecimal number: B");
                    break;
                case 1100:
                    Console.WriteLine("Hexadecimal number: C");
                    break;
                case 1101:
                    Console.WriteLine("Hexadecimal number: D");
                    break;
                case 1110:
                    Console.WriteLine("Hexadecimal number: E");
                    break;
                case 1111:
                    Console.WriteLine("Hexadecimal number: F");
                    break;
            }

            //4
            int sum = 0, n;
            Console.Write("enter the Number");
            x = Convert.ToInt32((Console.ReadLine());
            n = x;
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
                Console.ReadLine();
            }

            //5
            Console.WriteLine("Enter integer number: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + x);
                }
            }
        }
    }
}
