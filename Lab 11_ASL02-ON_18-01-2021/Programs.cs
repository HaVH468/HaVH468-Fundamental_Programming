using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_ASL02_ON_18_01_2021
{
    class Programs
    {
        public static void Main(string[] args)
        {
            DVDPlayer dvd = new DVDPlayer();
            dvd.InforDvd = "Harry Porter";
            Console.WriteLine(dvd.InforDvd);
            Convert c = new Convert();
            c.Divide(4, 3);
            c.Divide(4.2, 3.5);
            c.Divide(4.5f, 3.2f);
            SuperEngine spe = new SuperEngine();
            spe.Engine(100,2000,10);
            Engine1 egn = new Engine1();
            egn.Engine(100, 2000, 10);
        }
    }

    public class SuperEngine
    {
        public virtual void Engine(double power, int rpm, int cylinder)
        {
            Console.WriteLine($"Power is {power}");
        }
    }

    public class Engine1 : SuperEngine
    {
        public override void Engine(double power, int rpm, int cylinder)
        {
            Console.WriteLine($"Engine power is {power} and rpm is {rpm}");
        }
    }

}
