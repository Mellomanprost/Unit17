using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    /// <summary>
    /// Представляет объект - источник событий
    /// ( Иначе говоря, наблюдаемый объект )
    /// </summary>
    interface IPublisher
    {
        void AddSubscriber(ISubscriber sub);
        void RemoveSubscriber(ISubscriber o);
        void Publish();
    }
}
