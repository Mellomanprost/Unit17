using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    // Наш код, где необходимо использование класса-источника
    class Client
    {
        public void Request(DataSource dataSource)
        {
            dataSource.GetData();
        }
    }
}
