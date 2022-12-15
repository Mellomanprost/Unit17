using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageText = "Ваш номер заказа - 83456";

            // Отправляем заказ по SMS
            MessageSender sender = new SmsMessageSender("+79856455320");
            Message smsMessage = sender.Send(messageText);

            // Отправляем заказ по e-mail
            sender = new EmailMessageSender("orders@myshop.com");
            Message message = sender.Send(messageText);
        }
    }
}
