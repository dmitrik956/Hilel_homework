namespace BankAccountApp
{
    public class Account
    {
        public string Name { get; }
        public double Balance { get; private set; }

        public Account(string name, double initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Баланс не може бути менше за 0.");
            }

            Name = name;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сума повинна бути більше за 0.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"{amount} додано на рахунок {Name}.");
        }

        public void Withdrawal(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сума повинна бути більше за 0.");
                return;
            }

            if (Balance - amount < 0)
            {
                Console.WriteLine($"Недостатньо коштів на рахунку {Name}.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"{amount} знято з рахунку {Name}.");
        }
    }
}


namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

            heikkisAccount.Withdrawal(20);
            Console.WriteLine($"The balance of Heikki's account is now: {heikkisAccount.Balance}");

            heikkisSwissAccount.Deposit(200);
            Console.WriteLine($"The balance of Heikki's other account is now: {heikkisSwissAccount.Balance}");

            heikkisAccount.Withdrawal(1000);
            heikkisSwissAccount.Deposit(-50); 
        }
    }
}
