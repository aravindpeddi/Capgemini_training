//**Encapsulation Challenge**

//Create a `BankAccount` class where `balance` is a private field.Implement methods for `Deposit()` and `Withdraw()`, ensuring that withdrawal is only allowed if there is a sufficient balance.Prevent direct modification of `balance` from outside the class.


using System;
namespace Mynamespace
{
    class BankAccount
    {
        private decimal balance;
        public BankAccount()
        {
            balance = 0;
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Deposit amount cannot be negative");
            }
            else
            {
                Console.WriteLine("Successfully Deposited");
                balance += amount;
                Console.WriteLine($"Deposited Amount :{amount}. Remaining balance :{balance}");
            }
        }
        public void Withdrawl(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Withdrawl amount cannot be negative");
            }
            else
            {
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient Funds");
                }
                else
                {
                    Console.WriteLine("Successfully Withdrawn");
                    balance -= amount;
                    Console.WriteLine($"Withdrawn amount :{amount}. Balance :{balance}");
                }
            }
        }
        public void Balance()
        {
            Console.WriteLine($"Remaining balance :{balance}");
        }
    }
    //public class Program1
    //{
    //    static void Main()
    //    {
    //        BankAccount acc = new BankAccount();
    //        // string a = Console.ReadLine();
    //        // string b = Console.ReadLine();
    //        // acc.Deposit(int.Parse(a));
    //        // acc.Withdrawl(int.Parse(b));
    //        acc.Deposit(5000);
    //        acc.Deposit(-500);
    //        acc.Withdrawl(2000);
    //        acc.Withdrawl(-2000);
    //        acc.Withdrawl(10000);
    //        acc.Balance();
    //    }
    //}
} 