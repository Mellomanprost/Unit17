using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseGoodExample.Profiles
{
    /// <summary>
    /// Общий интерфейс для профилей посадки
    /// </summary>
    public interface ILandingProfile
    {
        void Execute();
    }
}
