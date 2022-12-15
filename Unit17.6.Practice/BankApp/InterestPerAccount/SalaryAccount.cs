using System;
using BankApp.Interfaces;

namespace BankApp.InterestPerAccount
{
    /// <summary>
    /// Зарплатный аккаунт
    /// </summary>
    class SalaryAccount : ICalculateInterestGeneral
    {
        public void CalculateInterest(Account account)
        {
            Console.WriteLine("Выбран расчет процентной ставки для зарплатного аккаунта.");

            // расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
