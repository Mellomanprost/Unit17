using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple
{
    public class Driver
    {
        public void Drive(ICarPack car)
        {
            car.Drive();
        }
    }
}
