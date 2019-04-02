using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class CreditAccount:Account
    {
        private static double _interestRate = 0.10;
        private static double _fee = 0.03;
        private static double _creditLimitTransaction = 5000;
        public double Payments { get; set; }
        public double InterestRate = _interestRate;
        public double Fee = _fee;
        public override double Balance { get ; set ; }
        public bool AddPayment(double amount)
        {
            if (amount <= _creditLimitTransaction)
            {
                Payments = Payments + amount;
                return true;
            }
            else 
            {
                Console.WriteLine("Sorry you have reached your credit limit transaction");
                return false;
            }
        }
        public double Charge()
        {
            if (Payments + Payments * Fee <= Balance)
            {
                Balance = Balance - (Payments + Payments * Fee);
                return (Payments + Payments * Fee); 
            }
            else
            {
                return 0;
            }
        }
        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
        
    }
        


    
}
