using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class LotteryAccount:SavingsAccount
    {
        private int winPercentage = 10000; // 1 to 10000 chances
        private double winAmount = 1000;
        public bool WinLottery(int luckyNumber)
        {
            Random random = new Random();
            if (random.Next(winPercentage) == luckyNumber)
            {
                Console.WriteLine("You WON!!!");
                Balance = Balance + winAmount;
                return true;
            }
            else
            {
                Console.WriteLine("You did not won.\nMaybe next time");
                return false;
            }
        }

    }
}
