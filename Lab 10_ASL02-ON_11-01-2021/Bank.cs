using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_ASL02_ON_11_01_2021
{
    public abstract class Bank
    {
        public abstract double GetBalance();
    }

    public class BankA :Bank
    {
        public override double GetBalance()
        {
            return 100.00;
        }
    }

    public class BankB : Bank
    {
        public override double GetBalance()
        {
            return 150.00;
        }
    }

    public class BankC : Bank
    {
        public override double GetBalance()
        {
            return 200.00;
        }
    }
}
