using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    class Client
    {
        void Main()
        {
            // Первый обработчик
            Handler handlerOne = new HandlerOne();

            // Второй обработчик
            Handler handlerTwo = new HandlerTwo();

            // Передача запроса по цепочке и обработка
            handlerOne.Successor = handlerTwo;
            handlerOne.HandleRequest(2);
        }
    }
}
