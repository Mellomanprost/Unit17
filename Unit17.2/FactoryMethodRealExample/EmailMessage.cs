﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealExample
{
    class EmailMessage : Message
    {
        public EmailMessage()
        {
            Console.WriteLine("E-mail отправлен!");
        }
    }
}
