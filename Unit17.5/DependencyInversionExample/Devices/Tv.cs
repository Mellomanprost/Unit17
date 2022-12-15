using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversionExample.Interfaces;

namespace DependencyInversionExample.Devices
{
    class Tv : IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("Вывод на телевизор");
        }
    }
}
