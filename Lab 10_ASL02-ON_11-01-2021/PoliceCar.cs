using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_ASL02_ON_11_01_2021
{
    interface IsEmergency
    {
        void Infrom();
    }
    interface IsLandVehicle
    {
        void Detail();
    }
    class PoliceCar : IsEmergency, IsLandVehicle
    {
        public void Detail()
        {
            Console.WriteLine("This is the detail of Land Vehicle");
        }

        public void Infrom()
        {
            Console.WriteLine("This is the inform of Emergency");
        }
    }
}
