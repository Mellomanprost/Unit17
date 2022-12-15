using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityGoodExample
{
    /// <summary>
    /// Общий интерфейс для классов - экспортеров
    /// </summary>
    interface IExporter
    {
        void Export(string text);
    }
}
