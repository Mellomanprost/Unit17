using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    /// <summary>
    /// Конкретная реализация источника событий
    /// ( наблюдаемого объекта )
    /// </summary>
    class ConcretePublisher : IPublisher
    {
        private List<ISubscriber> subscribers;

        public ConcretePublisher()
        {
            subscribers = new List<ISubscriber>();
        }
        public void AddSubscriber(ISubscriber sub)
        {
            subscribers.Add(sub);
        }
        public void RemoveSubscriber(ISubscriber o)
        {
            subscribers.Remove(o);
        }
        public void Publish()
        {
            foreach (ISubscriber subscriber in subscribers)
                subscriber.Update();
        }
    }
}
