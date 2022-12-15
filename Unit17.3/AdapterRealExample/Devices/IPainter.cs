using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRealExample.Devices
{
    /// <summary>
    /// Интерфейс устройства, печатающего на холсте
    /// </summary>
    interface IPainter
    {
        void Paint();
    }
}
