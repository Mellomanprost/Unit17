using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCloseGoodExample.Profiles;

namespace OpenCloseGoodExample
{
    class BoardComputer
    {
        public void PerformLanding(ILandingProfile landingProfile)
        {
            landingProfile.Execute();
        }
    }
}
