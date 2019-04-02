using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class SavingsAccount : Account
    {
        private static double _interestRate = 0.0001;
        public override double Balance { get ; set ; }
        public double InterestRate = _interestRate;
        public bool Withdraw(double amount)
        {
            if (amount <= Balance && amount <= TransactionLimit)
            {
                Balance = Balance - amount;
                return true;
            }
            else if (amount > Balance && amount <= TransactionLimit)
            {
                Console.WriteLine("The withdrawal can not be done cause of lack of your balance");
                return false;
            }
            else if (amount <= Balance && amount > TransactionLimit)
            {
                Console.WriteLine("The withdrawal can not be done cause of the transaction limit");
                return false;
            }
            else
            {
                Console.WriteLine("The withdrawal can not be done cause of both of transaction limit and lack of your balance");
                return false;
            }
        }
        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
        public double AddInterest()
        {
            Balance = Balance + Balance * InterestRate;
            return Balance * InterestRate;
        }
    }
}
