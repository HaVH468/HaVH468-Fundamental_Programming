using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_ASL02_ON_23_11_2020
{
    public class Time
    {
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }

        public string AddTime(Time T1, Time T2)
        {
            this.Hour = T1.Hour + T2.Hour;
            this.Min = T1.Min + T2.Min;
            this.Sec = T1.Sec + T2.Sec;
            return $"New time: {this.Hour}:{this.Min}:{this.Sec}";
        }
        
        //5
        public void ConvertTime(Time T1)
        {
            int s = T1.Hour * 3600 + T1.Min * 60 + T1.Sec;
            Console.WriteLine($"New time: {s}s");
        }
    }
}
