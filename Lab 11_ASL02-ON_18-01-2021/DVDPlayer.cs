using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_ASL02_ON_18_01_2021
{
    class DVDPlayer
    {
        private string Dvd;
        public string InforDvd
        {
            set { Dvd = value; }
            get
            {
                return $"The current disc is {Dvd}";
            }
        }
    }
}
