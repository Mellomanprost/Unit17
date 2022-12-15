using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionExample.Interfaces
{
    /// <summary>
    /// Универсальный интерфейс для вывода изображения
    /// </summary>
    public interface IHdmiInterface
    {
        void Display(string text);
    }
}
