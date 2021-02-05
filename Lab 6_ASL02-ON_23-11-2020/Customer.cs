using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_ASL02_ON_23_11_2020
{
    public class Customer
    {
        private string Name;
        private string Password;
        private string Phone;
        private string Address;
        private double Deposit;
        private double Withdraw;
       
        public Customer(string name, string password, string phone, string address, double deposit)
        {
            this.Name = name;
            this.Password = password;
            this.Phone = phone;
            this.Address = address;
            this.Deposit = deposit;
        }

        public void Infor (string name, string password)
        {
            if(name == this.Name && password == this.Password)
            {
                Console.WriteLine("Customer Information:");
                Console.WriteLine($"Name: {this.Name}");
                Console.WriteLine($"Phone: {this.Phone}");
                Console.WriteLine($"Deposit: {this.Deposit}");
            }
            else
            {
                Console.WriteLine("Name or password is incorect.");
            }
        }

        public double SetDeposit(double wth)
        {
            return this.Deposit = this.Deposit - wth;
        }
        public void Withdrawal(string name, string password)
        {
            if (name == this.Name && password == this.Password)
            {
                Console.Write("Money for withdraw: ");
                double money = Convert.ToDouble(Console.ReadLine());
                Console.Write("Deposit after withdraw: ",SetDeposit(money));
            }
            else
            {
                Console.WriteLine("Name or password is incorect.");
            }
        }
    }
}
