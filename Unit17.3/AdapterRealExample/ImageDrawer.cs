using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterRealExample.Devices;

namespace AdapterRealExample
{
    /// <summary>
    /// Класс для отрисовки изображений
    /// </summary>
    class ImageDrawer
    {
        // Метод, запускающий печать с помощью внешнего устройства
        public void DrawWith(IPrinter printer)
        {
            printer.Print();
        }
    }
}
