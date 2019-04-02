using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    abstract class Account
    {
        private double _balance = 0;
        private const double _transactionLimit = 2000;
        public abstract double Balance { get; set; }
        public double TransactionLimit = _transactionLimit;
        
    }
}
