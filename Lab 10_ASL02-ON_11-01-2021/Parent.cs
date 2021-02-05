using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_ASL02_ON_11_01_2021
{
    public abstract class Parent
    {
        public void Message() { }
    }

    public class ParentSub1 :Parent
    {
        public new void Message()
        {
            Console.WriteLine("This is first subclass");
        }
    }

    public class ParentSub2 : Parent
    {
        public new void Message()
        {
            Console.WriteLine("This is second subclass");
        }
    }
}
