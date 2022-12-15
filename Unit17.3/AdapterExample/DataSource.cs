using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    /// <summary>
    /// Класс - источник ресурса, к которому нужно подключиться
    /// </summary>
    class DataSource
    {
        public virtual void GetData()
        { }
    }
}
