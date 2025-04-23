namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        //        Создайте класс BankAccount, который моделирует банковский счет:
        //Поля:
        //    _balance(текущий баланс, private)
        //Статическое поле:
        //    _totalAccounts(общее количество созданных счетов, private)
        //Автосвойства:
        //    AccountNumber(номер счета, readonly)
        //    Balance(public геттер, private сеттер)
        //Конструктор:
        //    Увеличивает _totalAccounts и генерирует AccountNumber(например, случайный 4-значный номер).
        //Методы:
        //    Deposit(decimal amount) – пополняет баланс.
        //    Withdraw(decimal amount) – снимает деньги(если хватает средств, иначе выбрасывает исключение).
        //    ShowTotalAccounts() - выводит общее количество созданных счетов.
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class BankAccount
    {
        static decimal balance = 0;
        decimal totalAccounts = 0;
        public decimal AccountNumber { get; } = 0;
        public decimal Balance { get; private set; }        
        public BankAccount(decimal totalAccounts, decimal accountNumber)
        {
            this.totalAccounts = totalAccounts++;
            this.AccountNumber = accountNumber;
        }
        public void Deposit()
        {            
            Console.WriteLine("Сумма для пополнения балонса");
            decimal sumPopoln = 500;
            balance = balance + sumPopoln;
            Console.WriteLine($"Баланс пополнен на {sumPopoln}");
        }
        public void Withdraw()
        {
            Console.WriteLine("Сумма для снятия");
            decimal sumSnim = 380;
            balance = balance - sumSnim;
            Console.WriteLine($" C баланса списано {sumSnim}");
        }
    }
}
