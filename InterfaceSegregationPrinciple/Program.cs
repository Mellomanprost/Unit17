﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregationPrinciple.Cars;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // наш водитель
            var driver = new Driver();

            // водителю всё равно на чём ехать
            Console.WriteLine("Садимся в седан");
            driver.Drive(new Sedane());

            Console.WriteLine();

            Console.WriteLine("Садимся в джип");
            driver.Drive(new Suv());
        }
    }
}
