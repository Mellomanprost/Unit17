using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCloseGoodExample.Profiles;


namespace OpenCloseGoodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardComputer = new BoardComputer();

            // посадка на землю
            boardComputer.PerformLanding(new GroundLandingProfile());

            Console.WriteLine();

            // посадка на воду
            boardComputer.PerformLanding(new WaterLandingProfile());
        }
    }
}
