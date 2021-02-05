using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_ASL02_ON_01_02_2021
{
    class Program
    {
        public struct Book
        {
            public string Isbn;
            public string Title;
            public string Author;
        }

        //1
        public struct Company
        {
            public string Brand;
        }

        public struct Employee
        {
            public string Name;
            public string Position;

            public Company company;
        }
        static void Main(string[] args)
        {
            //2
            Book b1 = new Book();
            b1.Isbn = "111-AAA";
            b1.Title = "Fundamental Programming 1";
            b1.Author = "Petter";
            Book b2 = new Book();
            b2.Isbn = "111-BBB";
            b2.Title = "Programming Language";
            b2.Author = "Anna";
            Console.WriteLine(b1.Title +" " + b1.Author);
            //1
            Company com = new Company();
            com.Brand = "ABC";
            Employee emp = new Employee();
            emp.Name = "Diana";
            emp.Position = "Accounting";
            emp.company = com;
            Console.WriteLine(emp.Name + " " + emp.company);
            Delegate();
            Console.ReadKey();
        }

        //3
        public static int GetNum()
        {
            var random = new Random();
            return random.Next();
        }

        delegate int RandomNum();

        public static void Delegate()
        {
            RandomNum num;
            num = GetNum;
            Console.WriteLine(num());

        }
    }
}