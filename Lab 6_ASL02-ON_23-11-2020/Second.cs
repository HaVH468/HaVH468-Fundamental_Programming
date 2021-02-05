using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_ASL02_ON_23_11_2020
{
    public class Second
    {
        private int Sec;
        public void GetSec()
        {
            Console.WriteLine("Enter time in seconds:");
            int s = Convert.ToInt32(Console.ReadLine());
        }
        public void ConvertTime(int s)
        {
            int min = s % 3600;
            int sec = min % 60;
            int hour = (s - min*60 - sec) / 3600;
            Console.WriteLine($"New time: {hour}:{min}:{sec}");
        }
    }
}
