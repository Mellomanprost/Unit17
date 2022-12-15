using System;
using BankApp.InterestPerAccount;
using BankApp.Interfaces;

namespace BankApp
{
    public static class Calculator
    {
        // Метод выбора аккаунта для расчета процентной ставки
        public static void Calculate(Account account)
        {
            if (account.Type == "Обычный")
            {
                // расчет процентной ставк обычного аккаунта по правилам банка
                var regularAccount = new RegularAccount();
                regularAccount.CalculateInterest(account);
            }
            else if (account.Type == "Зарплатный")
            {
                // расчет процентной ставк зарплатного аккаунта по правилам банка
                var salaryAccount = new SalaryAccount();
                salaryAccount.CalculateInterest(account);
            }
            Display(account);
            //// Выводим посчитанную процентную ставку для соответствующего аккаунта
            //Console.WriteLine($"Процентная ставка для аккаунта {account.Type} = {account.Interest}");
        }

        // Метод для отображения результатов расчета процентной ставки
        static void Display(Account account)
        {
            // Выводим посчитанную процентную ставку для соответствующего аккаунта
            Console.WriteLine($"Процентная ставка для аккаунта {account.Type} = {account.Interest}");
        }
    }
}
