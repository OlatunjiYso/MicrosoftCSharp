using System;

namespace MiniBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("John Doe", 1000);
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
        }
    }
}
