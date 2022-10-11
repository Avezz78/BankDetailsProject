using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails
{
    internal class Bank : IAccount
    {
        public void Accountdetails()
        {
            Console.WriteLine("setting Account details");
        }

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // access modifier protected

        public Bank()
        {
        }

        public Bank(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
