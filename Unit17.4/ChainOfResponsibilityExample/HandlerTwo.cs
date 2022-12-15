using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    /// <summary>
    /// Реализация второго обработчика
    /// </summary>
    class HandlerTwo : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 2)
            {
                // Завершение обработки при выполненном условии
            }
            else if (Successor != null)
            {
                // Условие не выполнено - передаем дальше по цепи
                Successor.HandleRequest(condition);
            }
        }
    }
}
