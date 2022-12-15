using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    /// <summary>
    /// Базовый абстрактный класс
    /// </summary>
    abstract class BaseClass
    { }

    /// <summary>
    /// Конкретная реализация A
    /// </summary>
    class ConcreteClassA : BaseClass
    { }

    /// <summary>
    /// Конкретная реализация B
    /// </summary>
    class ConcreteClassB : BaseClass
    { }

    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
