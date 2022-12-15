using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    /// <summary>
    /// Тот, кто подписан на события, наблюдаемого объекта
    /// ( иначе говоря, наблюдатель )
    /// </summary>
    interface ISubscriber
    {
        void Update();
    }
}
