using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_ASL02_ON_18_01_2021
{
    public class Department
    {
        private string departname;
        public Department(string avalue)
        {
            departname = avalue;
        }
        public string Departname
        {
            get
            {
                return departname;
            }
        }
    }
    public class Departmain
    {
        public static int Main(string[] args)
        {
            Department d = new Department("COMPUTERSCIENCE");
            Console.WriteLine("The Department is: {0}", d.Departname);
            return 0;
        }
    }
}
