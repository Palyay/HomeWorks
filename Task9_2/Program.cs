using System;

namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        //        Создайте класс BankAccount, который моделирует банковский счет:
        {
            BankAccount cat = new BankAccount();
            BankAccount cat1 = new BankAccount();
            BankAccount cat2 = new BankAccount();
            cat.Deposit();
            cat1.Deposit();
            cat.Deposit();
            cat.Deposit();
            cat2.Deposit();
            cat2.Withdraw();
            cat1.Withdraw();
            cat2.Withdraw();
            cat2.Withdraw();
            BankAccount.ShowTotalAccounts();
            Console.ReadKey();
        }
    }
    class BankAccount
    {
        decimal _balance = 1000.25M;
        private static int _totalAccounts = 0;
        public int[] AccountNumber { get; }
        public static decimal Balance { get; private set; }
        public BankAccount()
        {
            Balance = _balance;
            int[] numbers = new int[4];
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = random.Next(0, 10);
                AccountNumber[i] = numbers[i];
            }
            _totalAccounts++;
        }
        public void Deposit()
        {
            Console.WriteLine($"Счет: {AccountNumber}, Сумма для пополнения балонса: ");
            decimal plus = Convert.ToDecimal(Console.ReadLine());
            Balance = _balance + plus;
            _balance = Balance;
        }
        public void Withdraw()
        {
            Console.WriteLine($"Счет: {AccountNumber}, Сумма для снятия: ");
            decimal minus = Convert.ToDecimal(Console.ReadLine());
            try
            {
                Balance = _balance - minus;
                if (Balance < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _balance = Balance;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка: недостаточно средств: ");
            }
        }
        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Всего созданных счетов: {_totalAccounts}");
        }
    }
}
