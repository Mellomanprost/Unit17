namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account
            {
                Type = "Обычный",
                Balance = 600.13,
            };

            var account2 = new Account
            {
                Type = "Зарплатный",
                Balance = 1300.15,
            };

            var account3 = new Account
            {
                Type = "Обычный",
                Balance = 50.3
            };

            Calculator.Calculate(account1);
            Calculator.Calculate(account2);
            Calculator.Calculate(account3);
        }
    }
}
