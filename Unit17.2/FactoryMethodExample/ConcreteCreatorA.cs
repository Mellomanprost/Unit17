using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    /// <summary>
    /// Конкретная реализация A
    /// </summary>
    class ConcreteCreatorA : Creator
    {
        //  Переопределенный Фабричный метод здесь возвращает конкретную реализацию
        public override BaseClass FactoryMethod()
        {
            return new ConcreteClassA();
        }
    }
}
