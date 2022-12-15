using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterRealExample.Devices;

namespace AdapterRealExample
{
    /// <summary>
    /// Адаптер от CanvasPrinter к IPrinter
    /// </summary>
    class CanvasPainterToPrinterAdapter : IPrinter
    {
        private CanvasPainter _canvasPainter;

        public CanvasPainterToPrinterAdapter(CanvasPainter canvasPainter)
        {
            _canvasPainter = canvasPainter;
        }

        public void Print()
        {
            _canvasPainter.Paint();
        }
    }
}
