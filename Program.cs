using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(1234,"sahil",5000.0);
            Console.WriteLine("Account number:"+b.Number);
            Console.WriteLine("Account holder name:"+b.Holder);
            Console.WriteLine("Account Balance:"+b.Balance);

            b.Deposit(5000.0);
            Console.WriteLine("Account balance after depositing:"+b.Balance);

            b.Withdraw(1000.0);
            Console.WriteLine("Account balance after withdrawing:"+b.Balance);
        }
    }
}
