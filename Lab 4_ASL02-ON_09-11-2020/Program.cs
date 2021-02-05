using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_ASL02_ON_09_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int n, i;
            double mean, median;
            Console.WriteLine("Enter number of data points:");
            n = int.Parse(Console.ReadLine());
            int[] data = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(i = 0; i < n; i++)
            {
                sum = sum + data[i];
            }
            mean = sum / n;
            if (n % 2 != 0)
            {
                median = data[n / 2];
            }
            else
            {
                median = (data[n / 2] - 1) + data[n / 2] / 2;
            }

            //2
            int[] a = new int[10];
            Console.Write("Enter the number of elements of the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are : ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}  ", a[i]);
            }            
            Console.WriteLine("The values store into the array in reverse are :");
            for (i = n - 1; i >= 0; i--)
            {
                Console.WriteLine("{0} ", a[i]);
            }

            //3
            int count = 0;
            for (i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements in the array:", count);

            //4
            Console.WriteLine("Enter the number of rows and columns of the first matrix :");
            Console.Write("Rows : ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            int[,] a1 = InputMtrix(r1, c1);
            Console.WriteLine("Enter the number of rows and columns of the second matrix :");
            Console.Write("Rows : ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            int c2 = Convert.ToInt32(Console.ReadLine());
            int[,] a2 = InputMtrix(r2, c2);
            int[,] result = new int[50, 50];
            if (c1 != r2)
            {
                Console.WriteLine("Mutiplication of Matrix is not possible.");
                Console.WriteLine("Column of first matrix and row of second matrix must be same.");
            }
            else
            {
                Console.WriteLine("The 1st matrix is :");
                DisplayMatrix(a1, r1, c1);
                Console.WriteLine("The 2nd matrix is :");
                DisplayMatrix(a2, r2, c2);

                for (i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        result[i, j] = 0;
                        for (i = 0; i < r1; i++)   
                        {
                            for (j = 0; j < c2; j++)  
                            {
                                sum = 0;
                                for (int k = 0; k < c1; k++)
                                    sum = sum + a1[i, k] * a2[k, j];
                                result[i, j] = sum;
                            }
                        }
                    }
                }
                Console.WriteLine("The multiplication of two matrix is :");
                DisplayMatrix(result, r1, c2);
            }

            //5
            Console.WriteLine("Enter the number of rows and columns of the matrix :");
            Console.Write("Rows : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] arr = InputMtrix(r, c);
            Console.WriteLine("The matrix is :");
            DisplayMatrix(arr, r, c);
            for (i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    result[j, i] = arr[i, j];
                }
            }
            Console.WriteLine("The Transpose of a matrix is : ");
            DisplayMatrix(result, c, r);
        }

        public static int[,] InputMtrix(int row, int col)
        {
            int[,] arr = new int[50, 50];
            Console.WriteLine("Enter elements in the first matrix :");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }

        public static void DisplayMatrix(int[,] a, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < col; j++)
                    Console.Write("{0}\t", a[i, j]);
            }
        }
    }
}
