using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversionExample.Devices;

namespace DependencyInversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //  выводим на монитор
            var connectedMonitor = new VideoAdapter(new Monitor());
            connectedMonitor.Display();

            //  выводим на телевизор
            var connectedTv = new VideoAdapter(new Tv());
            connectedTv.Display();
        }
    }
}
