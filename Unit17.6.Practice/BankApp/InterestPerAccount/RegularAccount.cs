using System;
using BankApp.Interfaces;

namespace BankApp.InterestPerAccount
{
    /// <summary>
    /// Обычный аккаунт
    /// </summary>
    class RegularAccount : ICalculateInterestGeneral
    {
        public void CalculateInterest(Account account)
        {
            Console.WriteLine("Выбран расчет процентной ставки для обычного аккаунта.");

            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
