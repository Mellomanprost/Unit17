using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    /// <summary>
    /// Абстрактный класс, от которого наследуются конкретные реализации
    /// </summary>
    abstract class Creator
    {
        /// Фабричный метод, который будет переопределен в классах-наследниках
        public abstract BaseClass FactoryMethod();
    }
}
