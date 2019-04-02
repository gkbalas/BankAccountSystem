using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class Customer
    {
        private bool _savingsAccount;
        private bool _creditAccount;
        private bool _lotteryAccount;
        public SavingsAccount SavingsAccount;
        public CreditAccount CreditAccount;
        public LotteryAccount LotteryAccount;
        public bool lotteryTicket;
        public double amount;
        public string savingsLogs;
        public string creditLogs;
        public string lotteryLogs;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Iban { get; set; }
        public int AccountType { get; set; }
        public void print(Account account )
        {
            Console.WriteLine($"IBAN: {Iban}\nName: {FirstName}, {LastName}\n" +
                $"Type: {account.GetType()}/nDate\t ");
        }
        public void OpenAccount()
        {
            Console.WriteLine("What type of account do you need?\n1. Savings Account\n2. Credit Account\n" +
                            "3. Lottery Account\n4. Quit\nGive the proper number: ");
            AccountType = int.Parse(Console.ReadLine());
            switch (AccountType)
            {
                
                case 1: // Create a savings account
                    SavingsAccount = new SavingsAccount();
                    if (!_creditAccount && !_savingsAccount && !_savingsAccount) // For new users we ask their info
                    {
                        Console.WriteLine("We would like to know some info about you.\nFirst Name: ");
                        FirstName = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        LastName = Console.ReadLine();
                        Iban = "GR 123...";
                        Console.WriteLine($"Your new IBAN is {Iban}");
                    }
                    _savingsAccount = true;
                    savingsLogs = $"IBAN: {Iban}\nName: {FirstName}, {LastName}\n" +
                    $"Type: Savings\nDate\t\t| Reason | Amount\t| Balance\n" +
                    $"====================================================";
                    break;
                case 2: // Create a Credit account
                    CreditAccount = new CreditAccount();
                    if (!_creditAccount && !_savingsAccount && !_savingsAccount)
                    {
                        Console.WriteLine("We would like to know some info about you.\nFirst Name: ");
                        FirstName = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        LastName = Console.ReadLine();
                        Iban = "GR 123...";
                        Console.WriteLine($"Your new IBAN is {Iban}");
                    }
                    _creditAccount = true;
                    creditLogs = $"IBAN: {Iban}\nName: {FirstName}, {LastName}\n" +
                    $"Type: Credit\nDate\t\t| Reason | Amount\t| Balance\n" +
                    $"====================================================";
                    break;
                case 3: // Create a Lottery account
                    LotteryAccount = new LotteryAccount();
                    if (!_creditAccount && !_savingsAccount && !_savingsAccount)
                    {
                        Console.WriteLine("We would like to know some info about you.\nFirst Name: ");
                        FirstName = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        LastName = Console.ReadLine();
                        Iban = "GR 123...";
                        Console.WriteLine($"Your new IBAN is {Iban}");
                    }
                    _lotteryAccount = true;
                    lotteryLogs = $"IBAN: {Iban}\nName: {FirstName}, {LastName}\n" +
                    $"Type: Lottery\nDate\t\t| Reason | Amount\t| Balance\n" +
                    $"====================================================";
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("You should give the proper number");
                    break;
            }
        }
        public void Menu()
        {
            
            bool mainQuit = true;
            while (mainQuit)
            {
                Console.WriteLine("Select your account type.\n1. Savings Account\n2. Credit Account" +
                                    "\n3. Lottery Account\n4. New Account\n5. Quit");
                int accountMenu = int.Parse(Console.ReadLine());
                switch (accountMenu)
                {
                    case 1: // Savings account Menu
                        bool savingsQuit = true;
                        while (savingsQuit)
                        {
                            if (_savingsAccount)
                            {
                                Console.WriteLine("What would you like to do?\n1. Withdraw\n2. Deposit\n3. Add Interest\n4. Print\n5. Quit");
                                int savingsMenu = int.Parse(Console.ReadLine());
                                switch (savingsMenu)
                                {
                                    case 1: // Withdraw
                                        Console.WriteLine("Amount of withdrawal: ");
                                        amount = double.Parse(Console.ReadLine());
                                        if (SavingsAccount.Withdraw(amount))
                                        {
                                            savingsLogs = savingsLogs + $"\n{DateTime.Now} | Withdraw\t| {amount}\t| {SavingsAccount.Balance}";
                                        }
                                        break;
                                    case 2: // Deposit
                                        Console.WriteLine("Amount of deposit: ");
                                        amount = double.Parse(Console.ReadLine());
                                        SavingsAccount.Deposit(amount);
                                        savingsLogs = savingsLogs + $"\n{DateTime.Now} | Deposit\t| {amount}\t| {SavingsAccount.Balance}";
                                        break;
                                    case 3: // Add Interest
                                        amount = SavingsAccount.AddInterest();
                                        savingsLogs = savingsLogs + $"\n{DateTime.Now} | Interest\t| {amount}\t| {SavingsAccount.Balance}";
                                        break;
                                    case 4: // Print
                                        Console.WriteLine(savingsLogs);
                                        break;
                                    case 5:
                                        savingsQuit = false;
                                        break;
                                    default:
                                        Console.WriteLine("You should press the proper number");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You do not have a savings account");
                                savingsQuit = false;
                            }
                        }
                        break;
                    case 2: // Credit account menu
                        bool creditQuit = true;
                        while (creditQuit)
                        {
                            if (_creditAccount)
                            {
                                Console.WriteLine("What would you like to do?\n1. Add Payment\n2. Charge\n3. Deposit\n4. Print\n5. Quit");
                                int creditMenu = int.Parse(Console.ReadLine());
                                switch (creditMenu)
                                {
                                    case 1: // Add payment
                                        Console.WriteLine("Amount of payment: ");
                                        amount = double.Parse(Console.ReadLine());
                                        if (CreditAccount.AddPayment(amount))
                                        {
                                            creditLogs = creditLogs + $"\n{DateTime.Now} | Payment\t| {amount}\t| {CreditAccount.Balance}";
                                        }
                                        break;
                                    case 2: // Charge
                                        amount = CreditAccount.Charge();
                                        creditLogs = creditLogs + $"\n{DateTime.Now} | Charge\t| {amount}\t| {CreditAccount.Balance}";
                                        break;
                                    case 3: // Deposit
                                        Console.WriteLine("Amount of deposit: ");
                                        amount = double.Parse(Console.ReadLine());
                                        CreditAccount.Deposit(amount);
                                        creditLogs = creditLogs + $"\n{DateTime.Now} | Deposit\t| {amount}\t| {CreditAccount.Balance}";
                                        break;
                                    case 4: // Print
                                        Console.WriteLine(creditLogs);
                                        break;
                                    case 5:
                                        creditQuit = false;
                                        break;
                                    default:
                                        Console.WriteLine("You should press the proper number");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You do not have a credit account");
                                creditQuit = false;
                            }
                        }
                        break;
                    case 3: // Lottery account menu
                        bool lotteryQuit = true;
                        while (lotteryQuit)
                        {
                            if (_lotteryAccount)
                            {
                                Console.WriteLine("What would you like to do?\n1. Withdraw\n2. Deposit\n3. Add Interest\n4. Print\n5. Quit");
                                int lotteryMenu = int.Parse(Console.ReadLine());
                                switch (lotteryMenu)
                                {
                                    case 1:
                                        Console.WriteLine("Amount of withdrawal: ");
                                        amount = double.Parse(Console.ReadLine());
                                        if (LotteryAccount.Withdraw(amount))
                                        {
                                            lotteryLogs = lotteryLogs + $"\n{DateTime.Now} | Withdraw\t| {amount}\t| {LotteryAccount.Balance}";
                                            lotteryTicket = true;
                                        }
                                        if (lotteryTicket)
                                        {
                                            Console.WriteLine("Give your lucky number: ");
                                            if (LotteryAccount.WinLottery(int.Parse(Console.ReadLine())))
                                            {
                                                lotteryLogs = lotteryLogs + $"\n{DateTime.Now} | Lottery\t| 1000\t| {LotteryAccount.Balance}";
                                            }
                                            lotteryTicket = false;
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Amount of deposit: ");
                                        amount = double.Parse(Console.ReadLine());
                                        LotteryAccount.Deposit(amount);
                                        lotteryTicket = true;
                                        lotteryLogs = lotteryLogs + $"\n{DateTime.Now} | Deposit\t| {amount}\t| {LotteryAccount.Balance}";
                                        Console.WriteLine("Give your lucky number: ");
                                        if (lotteryTicket)
                                        {
                                            Console.WriteLine("Give your lucky number: ");
                                            if (LotteryAccount.WinLottery(int.Parse(Console.ReadLine())))
                                            {
                                                lotteryLogs = lotteryLogs + $"\n{DateTime.Now} | Lottery\t| 1000\t| {LotteryAccount.Balance}";
                                            }
                                            lotteryTicket = false;
                                        }
                                        break;
                                    case 3:
                                        LotteryAccount.AddInterest();
                                        break;
                                    case 4:
                                        Console.WriteLine(lotteryLogs);
                                        break;
                                    case 5:
                                        lotteryQuit = false;
                                        break;
                                    default:
                                        Console.WriteLine("You should press the proper number");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You do not have a lottery account");
                                lotteryQuit = false;
                            }
                        }
                        break;
                    case 4: // Create new account for the existing customer
                        OpenAccount();
                        break;
                    case 5:
                        mainQuit = false;
                        break;
                    default:
                        Console.WriteLine("You should press the proper number");
                        break;
                }
            }
                
        }
       
    }

}

