using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    /// <summary>
    /// Адаптер для подключения
    /// </summary>
    class Adapter : DataSource
    {
        private DataConsumer _dataConsumer = new DataConsumer();

        // метод для получения ресурса
        public override void GetData()
        {
            _dataConsumer.GetSpecificData();
        }
    }
}
