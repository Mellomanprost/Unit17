using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Cars
{
    /// <summary>
    /// У нас премиум-седан, поэтому кроме обычных систем подключаем системы комфорта
    /// </summary>
    public class Sedane : ICarPack, IPremiumPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }

        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }
    }
}
