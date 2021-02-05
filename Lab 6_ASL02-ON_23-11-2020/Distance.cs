using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_ASL02_ON_23_11_2020
{
    public class Distance
    {
        public int feet { get; set; }
        public int inches { get; set; }

        public string showDistance()
        {
            return $"Feet: {feet} Inches: {inches}";
        }

        public void addDistance(Distance D1, Distance D2)
        {
            inches = D1.inches + D2.inches;
            feet = D1.feet + D2.feet + (inches / 12);
            inches = inches % 12;
        }
    }
}
